using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class ReceiveOrdersFingerDetails2
    {
        public ReceiveOrdersFingerDetails2(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public ReceiveOrdersFingerDetails2() { }
        public Int32 ID { get; set; }

        public Single? Quantity { get; set; }

        public Decimal? UnitCost { get; set; }

        public Single? ExtendedPrice { get; set; }

        public DateTime? DateReceived { get; set; }

        public Int32? ReceiveOrderID { get; set; }

        public Int32? ProductID { get; set; }

        public Int32? ModuleNum { get; set; }
        public Int32? CageNum { get; set; }
        public Int32? Salinity { get; set; }
        public Int32? Temp { get; set; }

        public Boolean PostedToInventory { get; set; }

        public Boolean IsSubmitted { get; set; }
    }
}
