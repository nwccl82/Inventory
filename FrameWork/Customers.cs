using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Customers
    {
        public Customers(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Customers() { }
        public Int32 ID { get; set; }   
        public String Company { get; set; }    
        public String LastName { get; set; }   
        public String FirstName { get; set; }  
        public String EmailAddress { get; set; }
        public String JobTitle { get; set; }  
        public String BusinessPhone { get; set; }
        public String HomePhone { get; set; }   
        public String MobilePhone { get; set; } 
        public String FaxNumber { get; set; } 
        public String Address { get; set; }  
        public String City { get; set; }  
        public String StateProvince { get; set; }
        public String ZipPostal { get; set; }   
        public String CountryRegion { get; set; }  
        public String WebPage { get; set; }    
        public String Notes { get; set; }   
        public String Attachments { get; set; } 
        public String CustomerName { get; set; }  
        public String FileAs { get; set; }
        public String TIN { get; set; }
    }
}
