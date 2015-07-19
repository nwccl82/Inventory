using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class DRSIForm
    {
        public DRSIForm(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public DRSIForm() { }

        public Int32 ID { get; set; }

        public Int32 CustomerFKID { get; set; }

        public Int32 ProductFKID { get; set; }

        public String TotalPcs { get; set; }

        public String TotalUOM { get; set; }

        public String TotalWeight { get; set; }

        public String TotalUnitCost { get; set; }

        public String TotalCost { get; set; }

        public String Company { get; set; }

        public String ProductName { get; set; }
    }
}
