using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Thick
    {
        public Thick(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Thick() { }
        public Int32 ID { get; set; }

        public String Thickness { get; set; }
    }
}
