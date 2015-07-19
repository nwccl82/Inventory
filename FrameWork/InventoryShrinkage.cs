using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class InventoryShrinkage
    {
        public InventoryShrinkage(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public InventoryShrinkage() { }
        public Int32 ID { get; set; }

        public DateTime? Date { get; set; }

        public Single? Quantity { get; set; }

        public String Reason { get; set; }

        public Int32? ProductID { get; set; } 

    }
}
