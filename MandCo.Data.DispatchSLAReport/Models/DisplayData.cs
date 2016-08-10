namespace MandCo.Data.DispatchSLAReport.Models
{
    public class DisplayData
    {
        public int TotalOrders {get; set;}
        public int TotalOrdersSLA { get; set; }
        public decimal TotalOrdersSLAPct { get; set; }

        public int ExpressOrders { get; set; }
        public int ExpressOrdersSLA { get; set; }
        public decimal ExpressOrdersSLAPct { get; set; }

        public int InternationalOrders { get; set; }
        public int InternationalOrdersSLA { get; set; }
        public decimal InternationalOrdersSLAPct { get; set; }

        public int StandardOrders { get; set; }
        public int StandardOrdersSLA { get; set; }
        public decimal StandardOrdersSLAPct { get; set; }

        public int StoreOrders { get; set; }
        public int StoreOrdersSLA { get; set; }
        public decimal StoreOrdersSLAPct { get; set; }
    }
}
