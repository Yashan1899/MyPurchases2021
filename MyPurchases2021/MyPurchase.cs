using System;

namespace MyPurchases2021
{
    public class MyPurchase
    {
        private int priority;
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? AproxPrice { get; set; }
        public KindOfActivity Activity { get; set; }
        public int Priority
        {
            get => priority;
            set
            {
                if (priority <= 3 && priority >= 1)
                    priority = value;
                else
                    throw new Exception("Priority must be from 1 to 3");
            }
        }
        public enum KindOfActivity
        { 
        Running = 1,
        Bike,
        Swimming,
        Tourism
        }
       
    }
}
