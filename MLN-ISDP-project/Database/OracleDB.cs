using System;
using System.Collections.Generic;
using System.Text;
//using System.Data.OracleClient; // doesn't exist anymore? wtf?
using System.Data.OleDb;
using System.Data.Common;
using System.Linq;
using System.Data;

namespace MLN_ISDP_project
{
    class OracleDB : IDisposable
    {
        #region Member Level Variables

        protected OleDbConnection m_dbConn;
        protected OleDbTransaction m_transaction;

        //mapping oracle types to system types? isn't used now. might be later.
        private readonly Dictionary<Type, System.Data.OleDb.OleDbType> typeMap = new Dictionary<Type, System.Data.OleDb.OleDbType>();


        #endregion

        #region Properties

        //makes us check connection when we wanna access the connection.
        private OleDbConnection dbConn
        {
            get
            {
                if (this.m_dbConn == null)
                {
                    //this.m_dbConn = new OdbcConnection(OracleDB.getConnectionString());
                    if (!this.isConnected()) { this.connect(); }
                }
                return this.m_dbConn;
            }
        }

        //same with the transaction, makes sure it's going whenever we try to get it
        public OleDbTransaction transaction
        {
            get
            {
                if (this.m_transaction == null) this.m_transaction = this.dbConn.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                return this.m_transaction;
            }
        }

        #endregion

        #region Constructors

        //TODO: make default constructor
        public OracleDB(string in_connectionString)
        {
            this.m_dbConn = new OleDbConnection(in_connectionString);
            this.loadMap();
            this.connect();
        }

        #endregion

        #region Methods

        //type mapping again, that was never used
        private void loadMap()
        {
            this.typeMap.Add(typeof(string), System.Data.OleDb.OleDbType.VarChar);
            //this.typeMap.Add(typeof(DateTime), System.Data.Odbc.OdbcType.DateTime); //not needed at the moment
            //this.typeMap.Add(typeof(DateTime?), System.Data.Odbc.OdbcType.DateTime);
            this.typeMap.Add(typeof(int), System.Data.OleDb.OleDbType.Integer);
            this.typeMap.Add(typeof(double), System.Data.OleDb.OleDbType.Double);
            //etc

        }

        //finally, getting connected
        public void connect()
        {
            //make sure it's not null, instantiate if it is
            if (this.m_dbConn == null)
            {
                this.m_dbConn = new OleDbConnection();
            }
            //check if it's connected. if it isn't, open the connection
            if (this.isConnected())
            {
                return;
            }

            this.m_dbConn.Open();
        }

        //closes it all out
        public void disconnect()
        {
            this.m_dbConn.Close();
            this.m_dbConn.Dispose();

            this.m_dbConn = null;
        }

        //checks if we're connected
        public bool isConnected()
        {

            return (this.dbConn.State == System.Data.ConnectionState.Open
                    || this.dbConn.State == System.Data.ConnectionState.Fetching
                    || this.dbConn.State == System.Data.ConnectionState.Executing);
        }

        //returns a datatable containing the resulting rows of the query sent in
        public DataTable readQuery(string in_sql)
        {
            //debug code
            //System.Diagnostics.Debug.WriteLine("OracleDB: executeSQL(" + in_sql + ")");

            //if there's no transaction in place, then we're safe to commit it when we're done.
            //if there is one, we don't wanna commit it until everything's finished with it
            bool commitOnComplete = false;
            if (this.m_transaction == null)
            {
                commitOnComplete = true;
                this.startTransaction();
            }

            OleDbCommand dbComm;
            OleDbDataReader dbReader;

            try
            {
                //do the connection shit
                dbComm = this.dbConn.CreateCommand();
                dbComm.CommandText = in_sql;
                dbComm.CommandType = System.Data.CommandType.Text;
                dbComm.Transaction = this.m_transaction;

                //execute that query
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

            //load the stream reader into a more concrete location, one we can return without the connection breaking
            DataTable dt = new DataTable();
            dt.Load(dbReader);
            return dt;
        }

        //tries to insert the passed sql, and returns the truth of the result
        public bool insertQuery(string in_sql)
        {
            //more debug
            //System.Diagnostics.Debug.WriteLine("OracleDB: executeSQL(" + in_sql + ")");

            //same reasons for checking the transaction/commit status as before
            bool commitOnComplete = false;
            if (this.m_transaction == null)
            {
                commitOnComplete = true;
                this.startTransaction();
            }

            //we could return this instead of the bool, but i prefer that to this
            int rowsAffected = 0;
            OleDbCommand dbComm;

            try
            {
                //connection nitty gritty
                dbComm = this.dbConn.CreateCommand();
                dbComm.CommandText = in_sql;
                dbComm.CommandType = System.Data.CommandType.Text;
                dbComm.Transaction = this.m_transaction;

                //and make it so, number one
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

            //returns true if we had any effect
            return (rowsAffected > 0);
        }

        //helper method for getting a transaction going
        public bool startTransaction()
        {
            if (this.m_transaction == null)
            {
                OleDbTransaction t = this.transaction;
                return true;
            }
            else
            {
                return false;
            }
        }

        //the same for commiting a transaction
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

        //if we fuck up and wanna not have done that
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

        //implemented the disposable interface at someone's advice, and i still don't really know why, but here it is
        public void Dispose()
        {
            this.disconnect();
        }

        #endregion
    }
}
