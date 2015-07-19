using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class WizardPages
    {        public WizardPages(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
    public WizardPages() { }
    public Int32 ID { get; set; }

    public Single? PageNumber { get; set; }

    public Single? WizardID { get; set; }

    public String FormName { get; set; } 

    }
}
