using System;

namespace MyPurchases2021
{
    public class MyPurchase
    {
        private int priority;
        public int? Id { get; set; }
        /// <summary>
        /// name of equipment
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// approximate price of equipment
        /// </summary>
        public int? AproxPrice { get; set; }
        /// <summary>
        /// kind of activity of equipment
        /// </summary>
        public KindOfActivity Activity { get; set; }
        /// <summary>
        /// priority in purchase of equipment
        /// </summary>
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
