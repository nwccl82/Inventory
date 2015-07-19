using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Inventory
    {
        public Inventory(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Inventory() { }
        public Int32 ID { get; set; }

        public Int32? ProductID { get; set; }

        public Single? ReorderLevel { get; set; }

        public Single? TargetLevel { get; set; }

        public Single? MinimumReorderQuantity { get; set; }

        public Single? Received { get; set; }

        public Single? OnOrder { get; set; }

        public Single? Shrinkage { get; set; }

        public Single? Shipped { get; set; }

        public Single? Allocated { get; set; }

        public Single? BackOrdered { get; set; }

        public Single? InitialLevel { get; set; }

        public Single? OnHand { get; set; }

        public Single? Available { get; set; }

        public Single? CurrentLevel { get; set; }

        public Single? BelowTargetLevel { get; set; }

        public Single? ReorderQuantity { get; set; }

    }
}
