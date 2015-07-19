using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Categories
    {
        public Categories(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Categories() { }
        public Int32 ID { get; set; }

        public String Category { get; set; } 

    }
}
