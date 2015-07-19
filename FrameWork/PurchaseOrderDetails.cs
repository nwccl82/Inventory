using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class PurchaseOrderDetails
    {
        public PurchaseOrderDetails(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public PurchaseOrderDetails() { }
        public Int32 ID { get; set; }

        public Single? Quantity { get; set; }

        public Decimal? UnitCost { get; set; }

        public Single? ExtendedPrice { get; set; }

        public DateTime? DateReceived { get; set; }

        public Int32? PurchaseOrderID { get; set; }

        public Int32? ProductID { get; set; }

        public Boolean PostedToInventory { get; set; }

        public Boolean IsSubmitted { get; set; } 

    }
}
