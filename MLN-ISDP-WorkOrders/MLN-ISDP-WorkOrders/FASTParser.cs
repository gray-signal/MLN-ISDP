using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLN_ISDP_WorkOrders
{
    class FASTParser
    {
        public string[] loadFile(string locationOnDisk)
        {
            string[] lines = System.IO.File.ReadAllLines(locationOnDisk);

            return lines;
        }

        
        public List<Part> createParts(string[] lines)
        {
            List<Part> parts = new List<Part>();

            //find first part number and
            //store index of 1st part in int
            //int index = 5;

            for (int index = 5; index <= lines.Length; index = index + 2)
            {
                Part p = new Part(lines[index], lines[index+1]);
                parts.Add(p);
            }

            return parts;
        }
    }
}
