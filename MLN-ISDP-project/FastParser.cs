using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLN_ISDP_project
{
    class FastParser
    {
        string[] lines;

        //default db connection
        static System.Data.OleDb.OleDbConnectionStringBuilder csBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder(
                "Provider=MSDAORA;Data Source=localhost;User ID=2023164;Password=#42Paradox;");
        static OracleDB dbConn = new OracleDB(csBuilder.ToString());

        public void loadFile(string locationOnDisk)
        {
            lines = System.IO.File.ReadAllLines(locationOnDisk);
        }


        public List<Part> createParts()
        {
            List<Part> parts = new List<Part>();

            //find first part number and
            //store index of 1st part in int
            //int index = 5;

            for (int index = 6; index <= lines.Length - 1; index = index + 2)
            {
                Part p = new Part(lines[index].Trim(), lines[index + 1]);
                p.load(dbConn);

                parts.Add(p);
            }

            return parts;
        }
    }
}
