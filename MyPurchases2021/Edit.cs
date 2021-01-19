using System;
using System.Linq;


namespace MyPurchases2021
{
    class Edit
    {
        // <summary>
        /// Edit equipment price
        /// </summary>

        public void EditEquipment()
        {
            using (var db = new MyPurcaseContext())
            {
                var allEquip = db.MyPurchases.ToList();
                foreach (var equip in allEquip)
                {
                    Console.WriteLine($"{equip.Id} - {equip.Name}");
                }
                // Get Id of equipment for editing
                int equipId = Add.ParseInt("ID-number of equip for editing");

                var equipForEdit = db.MyPurchases.FirstOrDefault(id => id.Id == equipId);
                if (equipForEdit !=null)
                {
                    int newEquipPrice = Add.ParseInt("new equip price");
                    equipForEdit.AproxPrice = newEquipPrice;
                    db.MyPurchases.Update(equipForEdit);
                }
                else
                    Console.WriteLine("Your entered wrong value");
                db.SaveChanges();
            }
        }
    }
}
