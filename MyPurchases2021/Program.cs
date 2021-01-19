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
                           
                            break;
                        case 2:
                           
                            break;
                        case 3:
                          
                            break;
                        case 4:
                           
                            break;
                        case 5:
                           
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
            
           
            // switch2  All, only 1-priority, only 2-priority,only 3-priority
            // method sort

            // Purchase (rendering screen with all goods and 1, then choose and write id of good, 
            // after delete good from DB)

        }
    }
}
