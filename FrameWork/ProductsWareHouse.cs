using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class ProductsWareHouse
    {
        public ProductsWareHouse(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public ProductsWareHouse() { }
        public int ID { get; set; }

        public int ProductId { get; set; }

        public decimal Out { get; set; }

        public decimal Return { get; set; }

        public DateTime DateEntered { get; set; }

    }

}

