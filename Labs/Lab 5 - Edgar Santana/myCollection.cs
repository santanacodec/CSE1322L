using System;

namespace Lab_5___Edgar_Santana
{
    class myCollection
    {
        static void Main(string[] args)
        {
            Item[] itemArray = new Item[5];
            for(int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Please enter B for Book or P for Periodical.");
                char BorP = Convert.ToChar(Console.ReadLine());
            }
            

            

        }
    }
}
