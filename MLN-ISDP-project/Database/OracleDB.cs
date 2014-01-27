using System;
using System.Collections.Generic;
using System.Text;
//using System.Data.OracleClient; // doesn't exist anymore? wtf?
using System.Data.Odbc;
using System.Data.Common;
using System.Linq;
using System.Data;

namespace MLN_ISDP_project
{
    class OracleDB : IDisposable
    {
        #region Member Level Variables

        protected OdbcConnection m_dbConn;
        protected OdbcTransaction m_transaction;

        private readonly Dictionary<Type, System.Data.Odbc.OdbcType> typeMap = new Dictionary<Type, System.Data.Odbc.OdbcType>();


        #endregion

        #region Properties

        private OdbcConnection dbConn
        {
            get
            {
                if (this.m_dbConn == null /* && this.user.authenticated */)
                {
                    //this.m_dbConn = new OdbcConnection(OracleDB.getConnectionString());
                    if (!this.isConnected()) { this.connect(); }
                }
                return this.m_dbConn;
            }
        }

        public OdbcTransaction transaction
        {
            get
            {
                if (this.m_transaction == null) this.m_transaction = this.dbConn.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                
                return this.m_transaction;
            }
        }

        #endregion

        #region Constructors

        public OracleDB(string in_connectionString)
        {
            this.m_dbConn = new OdbcConnection(in_connectionString);
            this.loadMap();
            this.connect();
        }

        #endregion

        #region Methods

        private void loadMap()
        {
            this.typeMap.Add(typeof(string), System.Data.Odbc.OdbcType.VarChar);
            //this.typeMap.Add(typeof(DateTime), System.Data.Odbc.OdbcType.DateTime); //not needed at the moment
            //this.typeMap.Add(typeof(DateTime?), System.Data.Odbc.OdbcType.DateTime);
            this.typeMap.Add(typeof(int), System.Data.Odbc.OdbcType.Int);
            this.typeMap.Add(typeof(double), System.Data.Odbc.OdbcType.Real);
            //etc

        }

        public void connect()
        {
            if (this.m_dbConn == null)
            {
                this.m_dbConn = new OdbcConnection();
            }
            if (this.isConnected())
            {
                return;
            }

            this.m_dbConn.Open();
        }

        public void disconnect()
        {
            this.m_dbConn.Close();
            this.m_dbConn.Dispose();

            this.m_dbConn = null;
        }

        public bool isConnected()
        {

            return (this.dbConn.State == System.Data.ConnectionState.Open
                    || this.dbConn.State == System.Data.ConnectionState.Fetching
                    || this.dbConn.State == System.Data.ConnectionState.Executing);
        }


        public DataTable readQuery(string in_sql)
        {
            System.Diagnostics.Debug.WriteLine("OracleDB: executeSQL(" + in_sql + ")");
            bool commitOnComplete = false;
            if (this.m_transaction == null)
            {
                commitOnComplete = true;
                this.startTransaction();
            }

            OdbcCommand dbComm;
            OdbcDataReader dbReader;

            try
            {
                dbComm = this.dbConn.CreateCommand();
                dbComm.CommandText = in_sql;
                dbComm.CommandType = System.Data.CommandType.Text;
                dbComm.Transaction = this.m_transaction;

                dbReader = dbComm.ExecuteReader();

                if (commitOnComplete)
                {
                    this.commitTransaction();
                }


            }
            catch (Exception e)
            {
                this.rollbackTransaction();
                throw e;
            }
            finally
            {
                dbComm = null;
            }

            DataTable dt = new DataTable();
            dt.Load(dbReader);
            return dt;
        }

        public bool insertQuery(string in_sql)
        {
                System.Diagnostics.Debug.WriteLine("OracleDB: executeSQL(" + in_sql + ")");
                bool commitOnComplete = false;
                if (this.m_transaction == null)
                {
                    commitOnComplete = true;
                    this.startTransaction();
                }

                int rowsAffected = 0;
                OdbcCommand dbComm;

                try
                {
                    dbComm = this.dbConn.CreateCommand();
                    dbComm.CommandText = in_sql;
                    dbComm.CommandType = System.Data.CommandType.Text;
                    dbComm.Transaction = this.m_transaction;

                    rowsAffected = dbComm.ExecuteNonQuery();

                    if (commitOnComplete)
                    {
                        this.commitTransaction();
                    }


                }
                catch (Exception e)
                {
                    this.rollbackTransaction();
                    throw e;
                }
                finally
                {
                    dbComm = null;
                }
                return (rowsAffected > 0);
        }

        public bool startTransaction()
        {
            if (this.m_transaction == null)
            {
                OdbcTransaction t = this.transaction;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool commitTransaction()
        {
            if (this.m_transaction == null)
            {
                return false;
            }
            this.m_transaction.Commit();
            this.m_transaction = null;
            return true;
        }

        public bool rollbackTransaction()
        {
            if (this.m_transaction == null)
            {
                return false;
            }
            this.m_transaction.Rollback();
            this.m_transaction = null;
            return true;
        }

        #endregion

        #region IDisposable Method

        public void Dispose()
        {
            this.disconnect();
        }

        #endregion
    }
}
