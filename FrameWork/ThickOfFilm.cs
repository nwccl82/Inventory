using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class ThickOfFilm
    {
        public ThickOfFilm(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public ThickOfFilm() { }
        public Int32 ID { get; set; }

        public String Thickness { get; set; }
    }
}
