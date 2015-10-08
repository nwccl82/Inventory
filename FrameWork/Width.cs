using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Width
    {
        public Width(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Width() { }
        public Int32 ID { get; set; }

        public String Widths { get; set; }
    }
}
