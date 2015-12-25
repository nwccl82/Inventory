using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class DailyMonitoring
    {
        public DailyMonitoring(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public DailyMonitoring() { }
        public int DailyID { get; set; }
        public int RRID { get; set; }

        public DateTime? DateofTrans { get; set; }

        public string TimeofTrans { get; set; }

        public string ProdID { get; set; }

        public string ItemDescription { get; set; }

        public int? BatchNo { get; set; }

        public int? ModuleNo { get; set; }

        public int? CageNo { get; set; }

        public int? TotalCount { get; set; }

        public int? Dead { get; set; }

        public int? Deform { get; set; }

        public int? Age { get; set; }

        public int? Salinity { get; set; }

        public int? Temp { get; set; }

        public string Weather { get; set; }

        public decimal? WeightofFood { get; set; }

        public string RecordedBy { get; set; }

        public string CheckBy { get; set; }

    }
}
