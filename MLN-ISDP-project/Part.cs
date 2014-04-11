using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace MLN_ISDP_project
{
    class Part /*: MLN_ISDP_project.Database.Persistence*/ //this was also for the factory pattern experiments
    {
        //enum that backs all the indicator shit
        public enum Indicator { NONE, INVOICE, ORDER }

        private string m_id;

        #region Properties

        //i was doing something weird with IDs before, this could go back to being the default
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
        public string OrderedFor { get; set; }


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

        //if it doesn't get created properly, then create it with a magic value for an ID
        public Part()
            : this("NO PART")
        {

        }

        //this is all the construction we need to do.
        //you'd think the load method stuff would go here, but it's vital to have that return value
        public Part(string id)
        {
            m_id = id;
        }

        public Part(string id, string requested)
        {
            m_id = id;
            Request = Int16.Parse(requested);            

        }

        //clone constructor (i have my reasons)
        public Part(Part other)
        {
            PartID = other.PartID;
            PartDescription = other.PartDescription;
            Section = other.Section;
            ListPrice = other.ListPrice;
            CostPrice = other.CostPrice;
            QuantityOnHand = other.QuantityOnHand;
            QuantityOnOrder = other.QuantityOnOrder;
            MinQuantity = other.MinQuantity;
            Reserved = other.Reserved;
            PurchaseIndicator = other.PurchaseIndicator;
            Request = other.Request;
            TotalCost = other.TotalCost;
            TotalList = other.TotalList;
            Receive = other.Receive;
            BackOrder = other.BackOrder;
            Deposit = other.Deposit;
            Net = other.Net;
            Amount = other.Amount;
            Dirty = other.Dirty;
        }

        #endregion

        #region Methods

        //let's try to pull the rest of ourself from the database
        internal bool load(OracleDB in_db)
        {
            bool loadComplete = false;

            //doublechecks connection, whatever
            if (!in_db.isConnected())
            {
                in_db.connect();
            }

            //gets a datatable of every damn column in the parts table for this row, if it exists
            DataTable dt = in_db.readQuery("SELECT * FROM Parts WHERE PartID = '" + this.m_id + "'");

            //if there is no row? we stay loaded-false and return negative. if not, then we set our properties like we didn't in the constructor
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    //nullable freaking types. i went a little happy with these.
                    //the ?? is a null coalescing operator. if the assignment returns null, then that takes over and gives a real value.
                    //cool shit.
                    PartDescription = (string)dt.Rows[0]["PartDescription"];
                    Section = (double?)dt.Rows[0].Field<double?>("Section") ?? 0;
                    ListPrice = (decimal?)dt.Rows[0].Field<decimal?>("ListPrice") ?? 0;
                    CostPrice = (decimal?)dt.Rows[0].Field<decimal?>("CostPrice") ?? 0;
                    QuantityOnHand = (double?)dt.Rows[0].Field<double?>("QuantityOnHand") ?? 0;
                    QuantityOnOrder = (double?)dt.Rows[0].Field<double?>("QuantityOnOrder") ?? 0;
                    MinQuantity = (double?)dt.Rows[0].Field<double?>("MinQuantity") ?? 0;
                    Reserved = dt.Rows[0].Field<double?>("Reserved") ?? 0;

                    //we loaded, woo!
                    loadComplete = true;
                }
            }

            PurchaseIndicator = Indicator.NONE;

            return loadComplete;
        }

        //commit should really be called save or persist or something, oops
        //but it saves any changes that mighta got made to the part
        internal bool commit(OracleDB in_db)
        {
            bool writeComplete = false;
            if (!in_db.isConnected())
            {
                in_db.connect();
            }

            //need to make sure we're setting it dirty everywhere it gets changed first
            //if (this.Dirty)
            //{
            //currently just updating the on hand and on order values. i don't think we want to permanently change ids, descriptions, prices...
            writeComplete = in_db.insertQuery("UPDATE Parts "
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
