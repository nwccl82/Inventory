using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class SalesReports
    {
        public SalesReports(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public SalesReports() { }
        public Int32 ID { get; set; }

        public String GroupByName { get; set; }

        public String GroupByDataField { get; set; }

        public String GroupByDisplayField { get; set; }

        public String ReportTitle { get; set; }

        public String FilterRowSource { get; set; }

        public Boolean Default { get; set; }

        public String Filter { get; set; }

        public String SalesDateField { get; set; }

        public String SalesDateTable { get; set; } 


    }
}
