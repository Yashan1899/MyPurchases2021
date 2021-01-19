using System;
using System.Linq;

namespace MyPurchases2021
{
    class Show
    {
        // <summary>
        /// Show all equipment
        /// </summary>
  public void ShowEquipment()
        {
            ShowActivityEquip(MyPurchase.KindOfActivity.Running);
            ShowActivityEquip(MyPurchase.KindOfActivity.Bike);
            ShowActivityEquip(MyPurchase.KindOfActivity.Swimming);
            ShowActivityEquip(MyPurchase.KindOfActivity.Tourism);


            void ShowActivityEquip(MyPurchase.KindOfActivity kindOfActivity)
            {
                using (var db = new MyPurcaseContext())
                {
                    var allEquip = db.MyPurchases
                        .OrderBy(p => p.Priority)
                        .Where(n => n.Activity == kindOfActivity)
                        .ToList();

                    Console.WriteLine($"{kindOfActivity}");
                    Console.WriteLine("__________________");
                    foreach (var equip in allEquip)
                    {
                        Console.WriteLine($"{equip.Name} - {equip.AproxPrice}uah  -  {equip.Priority}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
