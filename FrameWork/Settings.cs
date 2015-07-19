using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Settings
    {
        public Settings(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Settings() { }
        public Int32 ID { get; set; }

        public String Company { get; set; }

        public String BusinessPhone { get; set; }

        public String Address { get; set; }

        public String City { get; set; }

        public String StateProvince { get; set; }

        public String ZipPostal { get; set; }

        public String CountryRegion { get; set; }

        public Boolean ShowStartupScreen { get; set; }

        public String WebPage { get; set; }

        public String Email { get; set; }

        public String BusinessFax { get; set; }

        public String Build { get; set; } 

    }
}
