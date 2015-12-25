using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class ReceiveOrdersFinger
    {
         public ReceiveOrdersFinger(System.Data.DataRow row)
        {
            Helper.CopyProperties(row, this);
        }
         public ReceiveOrdersFinger() { }
         public int ID { get; set; }

         public DateTime? OrderDate { get; set; }

         public int SupplierID { get; set; }

         public int CreatedById { get; set; }

         public DateTime CreationDate { get; set; }

         public DateTime ExpectedDate { get; set; }

         public decimal ShippingFee { get; set; }

         public decimal Taxes { get; set; }

         public DateTime? PaymentDate { get; set; }

         public decimal? PaymentAmount { get; set; }

         public string PaymentMethod { get; set; }

         public string Notes { get; set; }

         public decimal OrderSubTotal { get; set; }

         public decimal OrderTotal { get; set; }

         public int? SubmittedById { get; set; }

         public DateTime? SubmittedDate { get; set; }

         public int? ClosedById { get; set; }

         public DateTime? ClosedDate { get; set; }

         public bool IsCompleted { get; set; }

         public bool IsSubmitted { get; set; }

         public bool IsNew { get; set; }

         public string StatusText { get; set; }

         public DateTime? DateofShipment { get; set; }

         public TimeSpan? TimeofShipment { get; set; }

         public DateTime? DateofArrival { get; set; }

         public TimeSpan? TimeofArrival { get; set; }

         public DateTime? DateReceive { get; set; }

         public TimeSpan? TimeReceive { get; set; }

         public TimeSpan? ReoxygenationStart { get; set; }

         public TimeSpan? ReoxygenationEnd { get; set; }

         public int SalinityInsideTheBag { get; set; }

         public int TemperatureInsideTheBag { get; set; }

         public TimeSpan? TimeAfterReceiptFromAirport { get; set; }

         public int Mortality { get; set; }

         public TimeSpan? TimeofArrival1 { get; set; }

         public TimeSpan? TimeofStocking { get; set; }

         public int Mortality1 { get; set; }

         public int Deformed { get; set; }

         public int Injured { get; set; }

         public int Missing { get; set; }

         public int PurchaseOrderID { get; set; }
    }
}
