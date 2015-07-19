using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Invoices
    {
        public Invoices(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Invoices() { }
        public Int32 ID { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? DueDate { get; set; }

        public Decimal? Tax { get; set; }

        public Decimal? Shipping { get; set; }

        public Int32? OrderID { get; set; }

        public Decimal? SubTotal { get; set; }

        public Decimal? AmountDue { get; set; } 

    }
}
