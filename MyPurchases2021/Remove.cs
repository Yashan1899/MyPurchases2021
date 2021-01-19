using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPurchases2021
{
    class Remove
    {
        // <summary>
        /// Remove equipment
        /// </summary>

        public void RemoveEquipment()
        {
            using (var db = new MyPurcaseContext())
            {
                var allEquip = db.MyPurchases.ToList();
                foreach (var equip in allEquip)
                {
                    Console.WriteLine($"{equip.Id} - {equip.Name}");
                }
                // Get Id of equipment for removing
                int equipId = Add.ParseInt("ID-number of equip for removing");

                var equipForRemove = db.MyPurchases.FirstOrDefault(id => id.Id == equipId);
                if (equipForRemove != null)
                    db.MyPurchases.Remove(equipForRemove);
                else
                    Console.WriteLine("Your entered wrong value");
                db.SaveChanges();
            }
        }
    }
}
