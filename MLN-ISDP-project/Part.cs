using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace MLN_ISDP_project
{
    class Part /*: MLN_ISDP_project.Database.Persistence*/
    {

        public enum Indicator { NONE, INVOICE, ORDER }

        private string m_id;

        #region Properties

        
        //public new string id
        //{
        //    get { return m_id; }
        //    set
        //    {
        //        m_id = value;
        //    }
        //}

        public string PartID 
        {
            get { return m_id; }
            set
            {
                m_id = value;
            }
        }

        //db properties
        public string PartDescription { get; set; }
        public double? Section { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public double? QuantityOnHand { get; set; }
        public double? QuantityOnOrder { get; set; }
        public double? MinQuantity { get; set; }
        public double? Reserved { get; set; }

        //calculated or selected properties
        public Indicator PurchaseIndicator { get; set; }

        //calculated/selected for both
        public int Request { get; set; } //is called order on invoice screen
        public decimal TotalCost { get; set; }
        public decimal TotalList { get; set; }

        //calculated/selected for lookup


        //calculated/selected for invoice
        public int Receive { get; set; }
        public int BackOrder { get; set; }
        public double Deposit { get; set; }
        public double Net { get; set; }
        public double Amount { get; set; }


        //utility properties
        public bool Dirty { get; set; }

        #endregion

        #region Constructors

        public Part() : this("NO PART")
        {
            
        }

        public Part(string id)
        {
            m_id = id;
        }

        #endregion

        #region Methods

        internal bool load(OracleDB in_db)
        {
            bool loadComplete = false;
            if (!in_db.isConnected())
            {
                in_db.connect();
            }

            DataTable dt = in_db.readQuery("SELECT * FROM Parts WHERE PartID = '" + this.m_id + "'");

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    PartDescription = (string)dt.Rows[0]["PartDescription"];
                    Section = (double?)dt.Rows[0].Field<double?>("Section") ?? 0;
                    ListPrice = (decimal?)dt.Rows[0].Field<decimal?>("ListPrice") ?? 0;
                    CostPrice = (decimal?)dt.Rows[0].Field<decimal?>("CostPrice") ?? 0;
                    QuantityOnHand = (double?)dt.Rows[0].Field<double?>("QuantityOnHand") ?? 0;
                    QuantityOnOrder = (double?)dt.Rows[0].Field<double?>("QuantityOnOrder") ?? 0;
                    MinQuantity = (double?)dt.Rows[0].Field<double?>("MinQuantity") ?? 0;
                    Reserved = dt.Rows[0].Field<double?>("Reserved") ?? 0;

                    loadComplete = true;
                }
            }

            PurchaseIndicator = Indicator.NONE;

            return loadComplete;
        }

        internal bool commit(OracleDB in_db)
        {
            bool writeComplete = false;
            if (!in_db.isConnected())
            {
                in_db.connect();
            }

            //if (this.Dirty)
            //{
                in_db.insertQuery("UPDATE Parts "
                                + "SET QuantityOnHand = '" + (this.QuantityOnHand - this.Receive) + "',"
                                + "QuantityOnOrder = '" + this.QuantityOnOrder + "'" 
                                + "WHERE PartID = '" + this.PartID + "'");

                this.Dirty = false;

            //}
            return writeComplete;
        }

        #endregion

    }
}
