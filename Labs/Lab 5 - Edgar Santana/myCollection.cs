using System;
using System.Collections.Generic;

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

                if (BorP == 'B')
                {
                    Console.WriteLine("Please enter the name of the Book");
                    string bookName = Console.ReadLine();

                    Console.WriteLine("Please enter the author of the Book");
                    string authorName = Console.ReadLine();

                    Console.WriteLine("Please enter the ISBN of the Book");
                    long isbnNum = Convert.ToInt64(Console.ReadLine());

                    itemArray[i] = new Book(bookName, isbnNum, authorName);
                }
                else if (BorP == 'P')
                {
                    Console.WriteLine("Please enter the name of the Periodical");
                    string periodicalName = Console.ReadLine();

                    Console.WriteLine("Please enter the issue Number");
                    int issueNumber = Convert.ToInt32(Console.ReadLine());

                    itemArray[i] = new Periodical(periodicalName, issueNumber);
                }
            }

            Console.WriteLine("Your Items: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(itemArray[i].getListing());
            }
        }
    }
}
