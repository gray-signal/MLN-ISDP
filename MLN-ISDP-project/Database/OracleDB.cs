using System;
using System.Collections.Generic;
using System.Text;
//using System.Data.OracleClient; // doesn't exist anymore? wtf?
using System.Data.Odbc;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace MLN_ISDP_project.Database
{
    class OracleDB : IDisposable
    {
        #region Member Level Variables

        private OdbcConnection m_dbConn;

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

        #endregion

        #region Methods

        private void loadMap()
        {
            this.typeMap.Add(typeof(Guid), System.Data.Odbc.OdbcType.UniqueIdentifier);
            this.typeMap.Add(typeof(string), System.Data.Odbc.OdbcType.VarChar);
            this.typeMap.Add(typeof(DateTime), System.Data.Odbc.OdbcType.DateTime);
            this.typeMap.Add(typeof(DateTime?), System.Data.Odbc.OdbcType.DateTime);
            this.typeMap.Add(typeof(int), System.Data.Odbc.OdbcType.Int);
            this.typeMap.Add(typeof(bool), System.Data.Odbc.OdbcType.Bit);
            this.typeMap.Add(typeof(double), System.Data.Odbc.OdbcType.Real); //was float, which isn't in OdbcTypes.
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
    }
}
