using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class FAQ
    {
        public FAQ(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public FAQ() { }

        public Int32 ID { get; set; }

        public String Question { get; set; }

        public String Answer { get; set; }

        public Single? MoreInfoID { get; set; } 

    }
}
