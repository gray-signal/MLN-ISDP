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
                "Driver={Microsoft ODBC for Oracle};Server=localhost;Uid=2023164;Pwd=#42Paradox;");

            OracleDB dbConnTest = new OracleDB(csBuilder.ToString());

            bool connectedTest = dbConnTest.isConnected();

            if (connectedTest) dbConnTest.disconnect();


        }
    }
}
