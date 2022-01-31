using System;

namespace Lab_3___Edgar_Santana
{
    class Driver
    {        
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();
            int quizChoice;
            while (true)
            {
                Console.WriteLine("What would you like to do?");

                Console.WriteLine("1. Add a question to the quiz");
                Console.WriteLine("2. Remove a question from the quiz");
                Console.WriteLine("3. Modify a question in the quiz");
                Console.WriteLine("4. Take the quiz");
                Console.WriteLine("5. Quit");
                quizChoice = Convert.ToInt32(Console.ReadLine());
            
                switch (quizChoice)
                {
                    case 1:
                        quiz.add_question();
                        continue;
                    case 2:
                        quiz.remove_question();
                        continue;
                    case 3:
                        quiz.modify_question();
                        continue;
                    case 4:
                        quiz.give_quiz();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }

        }
    }
}
