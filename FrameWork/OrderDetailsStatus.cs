using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class OrderDetailsStatus
    {
        public OrderDetailsStatus(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public OrderDetailsStatus() { }
        public Int32 ID { get; set; }

        public Single? StatusID { get; set; }

        public String StatusText { get; set; } 

    }
}
