using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class Orders
    {
        public Orders(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
        public Orders() { }
        public Int32 ID { get; set; }

        public DateTime? OrderDate { get; set; }

        public Int32? EmployeeID { get; set; }

        public DateTime? ShippedDate { get; set; }

        public String ShipAddress { get; set; }

        public String ShipCity { get; set; }

        public String ShipStateProvince { get; set; }

        public String ShipZIPPostal { get; set; }

        public String ShipCountryRegion { get; set; }

        public Decimal? ShippingFee { get; set; }

        public Decimal? Tax { get; set; }

        public String PaymentType { get; set; }

        public DateTime? PaymentDate { get; set; }

        public String Notes { get; set; }

        public Single? TaxRate { get; set; }

        public Single? OrderMonth { get; set; }

        public Single? OrderYear { get; set; }

        public Decimal? OrderSubTotal { get; set; }

        public Decimal? OrderTotal { get; set; }

        public DateTime? ClosedDate { get; set; }

        public Single? OrderQuarter { get; set; }

        public String ShipName { get; set; }

        public String StatusText { get; set; }

        public Single? StatusID { get; set; }

        public Boolean IsNew { get; set; }

        public Int32? ShipperID { get; set; }

        public Boolean IsCompleted { get; set; }

        public Boolean IsShipped { get; set; }

        public Boolean IsInvoiced { get; set; }

        public Boolean IsActive { get; set; }

        public Int32? CustomerID { get; set; }

    }
}
