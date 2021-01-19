using System;
using System.Linq;

namespace MyPurchases2021
{
    class Purchased
    {
        // <summary>
        /// Purchased equipment
        /// </summary>

        public void PurchasedEquipment()
        {
            using (var db = new MyPurcaseContext())
            {
                var allEquip = db.MyPurchases.ToList();
                foreach (var equip in allEquip)
                {
                    Console.WriteLine($"{equip.Id} - {equip.Name}");
                }
                // Get Id of purchased equipment 
                int equipId = Add.ParseInt("ID-number of equip which was purchased");

                var purchasedEquip = db.MyPurchases.FirstOrDefault(id => id.Id == equipId);
                if (purchasedEquip != null)
                    db.MyPurchases.Remove(purchasedEquip);
                else
                    Console.WriteLine("Your entered wrong value");
                db.SaveChanges();
            }
        }
    }
}
