using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Color
    {
        public Color(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Color() { }
        public Int32 ID { get; set; }

        public String Colors { get; set; }
    }
}
