using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace MLN_ISDP_project
{
    class Part : MLN_ISDP_project.Database.Persistence
    {

        public enum Indicator { INVOICE, ORDER, NONE }

        private string m_id;

        #region Properties

        public new string id
        {
            get { return m_id; }
            set
            {
                m_id = value;
            }
        }

        public string PartID 
        {
            get { return m_id; }
            set
            {
                m_id = value;
            }
        }


        public string PartDescription { get; set; }
        public double Section { get; set; }
        public double ListPrice { get; set; }
        public double CostPrice { get; set; }
        public long QuantityOnHand { get; set; }
        public long QuantityOnOrder { get; set; }
        public long MinQuantity { get; set; }
        public long Reserved { get; set; }

        #endregion

        #region Methods

        internal void load(OracleDB in_db)
        {
            if (!in_db.isConnected())
            {
                in_db.connect();
            }

            DataTable dt = in_db.readQuery("SELECT * FROM Parts WHERE PartID = '1506631U03'"/* + this.m_id*/);

            
            Console.WriteLine("datatable: " + dt.ToString());
        }

        #endregion

    }
}
