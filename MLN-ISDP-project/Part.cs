using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLN_ISDP_project
{
    class Part : MLN_ISDP_project.Database.Persistence
    {
        #region Properties

        public string PartID { get; set; }
        public string PartDescription { get; set; }
        public double Section { get; set; }
        public double ListPrice { get; set; }
        public double CostPrice { get; set; }
        public long QuantityOnHand { get; set; }
        public long QuantityOnOrder { get; set; }
        public long MinQuantity { get; set; }
        public long Reserved { get; set; }

        #endregion

    }
}
