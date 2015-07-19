using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Sizes
    {
        public Sizes(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Sizes() { }
        public Int32 ID { get; set; }
        public String ProductSize { get; set; }
    }
}
