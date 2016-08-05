namespace MandCo.Data.DispatchSLAReport.Models
{
    public class DisplayData
    {
        //Last 24 Hours Data
        public int lastDay_TotalOrders {get; set;}
        public int lastDay_TotalOrdersSLA { get; set; }
        public float lastDay_TotalOrdersSLAPct { get; set; }

        public int lastDay_ExpressOrders { get; set; }
        public int lastDay_ExpressOrdersSLA { get; set; }
        public float lastDay_ExpressOrdersSLAPct { get; set; }

        public int lastDay_InternationalOrders { get; set; }
        public int lastDay_InternationalOrdersSLA { get; set; }
        public float lastDay_InternationalOrdersSLAPct { get; set; }

        public int lastDay_StandardOrders { get; set; }
        public int lastDay_StandardOrdersSLA { get; set; }
        public float lastDay_StandardOrdersSLAPct { get; set; }

        public int lastDay_StoreOrders { get; set; }
        public int lastDay_StoreOrdersSLA { get; set; }
        public float lastDay_StoreOrdersSLAPct { get; set; }


        //Custom Time Frame
        public int customTimeFrame_TotalOrders { get; set; }
        public int customTimeFrame_TotalOrdersSLA { get; set; }
        public float customTimeFrame_TotalOrdersSLAPct { get; set; }

        public int customTimeFrame_ExpressOrders { get; set; }
        public int customTimeFrame_ExpressOrdersSLA { get; set; }
        public float customTimeFrame_ExpressOrdersSLAPct { get; set; }

        public int customTimeFrame_InternationalOrders { get; set; }
        public int customTimeFrame_InternationalOrdersSLA { get; set; }
        public float customTimeFrame_InternationalOrdersSLAPct { get; set; }

        public int customTimeFrame_StandardOrders { get; set; }
        public int customTimeFrame_StandardOrdersSLA { get; set; }
        public float customTimeFrame_StandardOrdersSLAPct { get; set; }

        public int customTimeFrame_StoreOrders { get; set; }
        public int customTimeFrame_StoreOrdersSLA { get; set; }
        public float customTimeFrame_StoreOrdersSLAPct { get; set; }
    }
}
