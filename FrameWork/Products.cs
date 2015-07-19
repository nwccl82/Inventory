using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Products
    {
        public Products(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Products() { }
        public Int32 ID { get; set; }

        public String ProductCode { get; set; }

        public String ProductName { get; set; }

        public Decimal? StandardCost { get; set; }

        public Decimal? ListPrice { get; set; }

        public String QuantityPerUnit { get; set; }

        public Boolean Discontinued { get; set; }

        public String Attachments { get; set; }

        public String Description { get; set; }

        public Int32? SupplierID { get; set; }

        public Int32? CategoryID { get; set; }
        
        public Int32 UnitOfMeasureID { get; set; }

        public Int32 ProductSizeID { get; set; } 


    }
}
