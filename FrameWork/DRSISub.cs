using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class DRSISub
    {
         public DRSISub(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
         public DRSISub() { }
         public Int32 ID { get; set; }

         public Int32? DRSiformID { get; set; }

         public String BatchNo { get; set; }

         public String ModuleNo { get; set; }

         public String CageNo { get; set; }

         public String Weight { get; set; }

         public String UnitOfMeasure { get; set; } 
    }
}
