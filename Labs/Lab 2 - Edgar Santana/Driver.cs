using System;

namespace Lab_2___Edgar_Santana
{
    class Driver
    {
        static void Main(string[] args)
        {
            StockItem milk = new StockItem("1 Gallon of Milk", 3.60, 15);
            StockItem bread = new StockItem("1 Loaf of Bread", 1.98, 30);

            Console.WriteLine("Please select a number from our menu");
            Console.WriteLine("1. Sold One Milk");
            Console.WriteLine("2. Sold One Bread");
            Console.WriteLine("3. Change price of Milk");
            Console.WriteLine("4. Change price of Bread");
            Console.WriteLine("5. Add Milk to Inventory");
            Console.WriteLine("6. Add Bread to Inventory");
            Console.WriteLine("7. See Inventory");
            Console.WriteLine("8. Quit");
            int menuNumber = Convert.ToInt32(Console.ReadLine());

            switch(menuNumber)
            {
                case 1:
                    milk.setLowerQuantity(1);
                    Console.WriteLine(milk.ToString());
                    break;
                case 2:
                    bread.setLowerQuantity(1);
                    Console.WriteLine(bread.ToString());
                    break;
                case 3:
                    Console.WriteLine("Please enter a new price for Milk.");
                    double newMilkPrice = Convert.ToDouble(Console.ReadLine());
                    milk.setPrice(newMilkPrice);
                    Console.WriteLine(milk.ToString());
                    break;
                case 4:
                    Console.WriteLine("Please enter a new price for Bread.");
                    double newBreadPrice = Convert.ToDouble(Console.ReadLine());
                    bread.setPrice(newBreadPrice);
                    Console.WriteLine(bread.ToString());
                    break;
                case 5:
                    Console.WriteLine("How many Milks do you want to add to inventory?");
                    int milkAdded = Convert.ToInt32(Console.ReadLine());
                    milk.setHigherQuantity(milkAdded);
                    Console.WriteLine(milk.ToString());
                    break;
                case 6:
                    Console.WriteLine("How many Breads do you want to add to inventory?");
                    int breadAdded = Convert.ToInt32(Console.ReadLine());
                    milk.setHigherQuantity(breadAdded);
                    Console.WriteLine(bread.ToString());
                    break;
                case 7:
                    Console.WriteLine(milk.ToString());
                    Console.WriteLine(bread.ToString());
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
