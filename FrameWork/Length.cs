using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Length
    {
        public Length(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Length() { }
        public Int32 ID { get; set; }

        public String Lengths { get; set; }
    }
}
