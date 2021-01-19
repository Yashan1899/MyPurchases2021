using System;

namespace MyPurchases2021
{
    class Add
    {
        // <summary>
        /// Add new equipment
        /// </summary>

        public void AddEquipment(MyPurchase myPurchase)
        {
            // get equipment name
            Console.WriteLine("Enter new equipment:");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name can't be empty", nameof(name));

            // get equipment approximate price
            int aproxPrice = ParseInt("approximate price");

            // get equipment kind of activity for
            MyPurchase.KindOfActivity activity;
            Console.WriteLine("Enter kind of activity: 1) Running 2) Bike 3) Swimming 4) Tourism");
            string kindOfActivity = Console.ReadLine();
            if (!Enum.TryParse(kindOfActivity, out activity))
                Console.WriteLine("It is not correct data. Try again");
            else
                activity = (MyPurchase.KindOfActivity)Enum.Parse(typeof(MyPurchase.KindOfActivity), kindOfActivity, ignoreCase: true);

            // get equipment priority
            int priority = ParseInt("priority");

            using (var db = new MyPurcaseContext())
            {
                var newEquipment = new MyPurchase()
                {
                    Name = name,
                    AproxPrice = aproxPrice,
                    Activity = activity,
                    Priority = priority
                };
                db.MyPurchases.Add(newEquipment);

                db.SaveChanges();
            }
        }
        /// <summary>
        /// template-method for TryParse to Int
        /// </summary>
        public static int ParseInt(string name)
        {
            while (true)
            {
                Console.WriteLine("Enter {name}:");
                if (!int.TryParse(Console.ReadLine(), out int value))
                   Console.WriteLine($"Wrong format of {name}");
                else
                  return value;
            }
        }
    }
}