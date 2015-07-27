using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class ReceiveOrders
    {
        public ReceiveOrders(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public ReceiveOrders() { }
        public Int32 ID { get; set; }

        public DateTime? OrderDate { get; set; }

        public Int32? SupplierID { get; set; }

        public Int32? CreatedById { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ExpectedDate { get; set; }

        public Decimal? ShippingFee { get; set; }

        public Decimal? Taxes { get; set; }

        public DateTime? PaymentDate { get; set; }

        public Decimal? PaymentAmount { get; set; }

        public String PaymentMethod { get; set; }

        public String Notes { get; set; }

        public Decimal? OrderSubTotal { get; set; }

        public Decimal? OrderTotal { get; set; }

        public Int32? SubmittedById { get; set; }

        public DateTime? SubmittedDate { get; set; }

        public Int32? ClosedById { get; set; }

        public DateTime? ClosedDate { get; set; }

        public Boolean IsCompleted { get; set; }

        public Boolean IsSubmitted { get; set; }

        public Boolean IsNew { get; set; }

        public String StatusText { get; set; } 
    }
}
