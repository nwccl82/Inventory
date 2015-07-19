using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Employees
    {
        public Employees(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Employees() { }
        public Int32 ID { get; set; }

        public String Email { get; set; }

        public String FullName { get; set; }

        public String Login { get; set; }
        public String passwords { get; set; }
        public String LastName { get; set; } 

    }
}
