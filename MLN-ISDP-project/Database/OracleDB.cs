using System;
using System.Collections.Generic;
using System.Text;
//using System.Data.OracleClient; // doesn't exist anymore? wtf?
using System.Data.Odbc;
using System.Data.Common;
using System.Linq;

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

        public DbTransaction transaction
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



        #endregion

        #region IDisposable Method

        public void Dispose()
        {
            this.disconnect();
        }

        #endregion
    }
}
