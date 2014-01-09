using System;
using System.Collections.Generic;
using System.Text;
//using System.Data.OracleClient; // doesn't exist anymore? wtf?
using System.Data.Common;
using System.Linq;
using System.Text;

namespace MLN_ISDP_project.Database
{
    class OracleDB : IDisposable
    {
        #region Member Level Variables

        // could use System.Data.SqlDbType, but that's only if we were using MS SQL. need to find the proper dbtype
        //  when i download Oracle's own provider libraries? placeholder for now
        private readonly Dictionary<Type, System.Data.DbType> typeMap = new Dictionary<Type, System.Data.DbType>();


        #endregion


    }
}
