using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLN_ISDP_project
{
    class Test
    {
        public static void test()
        {
            var csBuilder = new System.Data.Odbc.OdbcConnectionStringBuilder(
                "Driver={Microsoft ODBC for Oracle};Server=placeholder;Uid=placeholder;Pwd=placeholder;");

            OracleDB test = new OracleDB(csBuilder.ToString());
        }
    }
}
