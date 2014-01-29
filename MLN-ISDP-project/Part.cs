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

        public enum Indicator { INVOICE, ORDER, NONE }

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


        public string PartDescription { get; set; }
        public double? Section { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public double? QuantityOnHand { get; set; }
        public double? QuantityOnOrder { get; set; }
        public double? MinQuantity { get; set; }
        public double? Reserved { get; set; }

        #endregion

        #region Constructors

        public Part() : this("INVALID PART")
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
                    ListPrice = (decimal?)dt.Rows[0].Field<decimal?>("ListPrice");
                    CostPrice = (decimal?)dt.Rows[0].Field<decimal?>("CostPrice");
                    QuantityOnHand = (double?)dt.Rows[0].Field<double?>("QuantityOnHand") ?? 0;
                    QuantityOnOrder = (double?)dt.Rows[0].Field<double?>("QuantityOnOrder") ?? 0;
                    MinQuantity = (double?)dt.Rows[0].Field<double?>("MinQuantity") ?? 0;
                    Reserved = dt.Rows[0].Field<double?>("Reserved") ?? 0;

                    loadComplete = true;
                }
            }


            return loadComplete;
        }

        #endregion

    }
}
