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
        }
    }
}
