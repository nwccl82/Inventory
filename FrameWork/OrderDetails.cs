using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class OrderDetails
    {
        public OrderDetails(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public OrderDetails() { }
        public Int32 ID { get; set; }

        public Int32? OrderID { get; set; }

        public Int32? ProductID { get; set; }

        public Single? Quantity { get; set; }

        public Decimal? UnitPrice { get; set; }

        public Single? Discount { get; set; }

        public Decimal? ExtendedPrice { get; set; }

        public Single? StatusID { get; set; }

        public String StatusText { get; set; }

        public Boolean InsufficientInventory { get; set; }

        public Boolean IsProductAllocated { get; set; }

        public Boolean IsInvoiced { get; set; }

        public Boolean IsShipped { get; set; }

        public Boolean IsBackOrdered { get; set; } 

    }
}
