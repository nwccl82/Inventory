using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{

    public class AccessLevels
    {
        public AccessLevels(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public AccessLevels() { }
        public int IDAccess { get; set; }

        public string AccessName { get; set; }

        public string AccessDef { get; set; }

    }

}
