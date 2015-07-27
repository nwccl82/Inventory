using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class ReceiveOrderDetails
    {
        public ReceiveOrderDetails(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public ReceiveOrderDetails() { }
        public Int32 ID { get; set; }

        public Single? Quantity { get; set; }

        public Decimal? UnitCost { get; set; }

        public Single? ExtendedPrice { get; set; }

        public DateTime? DateReceived { get; set; }

        public Int32? ReceiveOrderID { get; set; }

        public Int32? ProductID { get; set; }

        public Boolean PostedToInventory { get; set; }

        public Boolean IsSubmitted { get; set; } 
    }
}
