using System;

namespace MyPurchases2021
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPurchase myPurchase = new MyPurchase() 
            { 
                Name = "Tent", Activity = MyPurchase.KindOfActivity.Tourism, AproxPrice = 3500, Priority = 3
            };
            var add = new Add();
            var edit = new Edit();
            var remove = new Remove();
            var show = new Show();
            var purchased = new Purchased();

            bool flag = true;
            while (flag)
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("1.Show  \t 2. Add  \t 3. Edit");
                Console.WriteLine("4. Delete \t 5. Purchased \t 6. Exit");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Enter the number of action:");
                Console.ForegroundColor = color;
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            show.ShowEquipment();
                            break;
                        case 2:
                            add.AddEquipment(myPurchase);
                            break;
                        case 3:
                            edit.EditEquipment();
                            break;
                        case 4:
                            remove.RemoveEquipment();
                            break;
                        case 5:
                            purchased.PurchasedEquipment();
                            break;
                        case 6:
                            flag = false;
                            continue;
                    }
                }
                catch (Exception ex)
                {
                    color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = color;
                }
            }
        }
    }
}
