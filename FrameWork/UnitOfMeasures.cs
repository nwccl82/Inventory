using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class UnitOfMeasures
    {
        public UnitOfMeasures(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public UnitOfMeasures() { }
        public Int32 ID { get; set; }
        public String UnitOfMeasure { get; set; }
       
    }
}
