using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3___Edgar_Santana
{
    class Quiz
    {
        private List<Question> quizMaker = new List<Question>();

        public void addQuestion()
        {
            string question;
            string answer;
            int difficulty;

            Console.WriteLine("What is your question?");
            question = Console.ReadLine();

            Console.WriteLine("What is the answer?");
            answer = Console.ReadLine();

            Console.WriteLine("What is the level of difficulty for your question?");
            difficulty = Convert.ToInt32(Console.ReadLine());

            Question quest = new Question(question, answer, difficulty);
            quizMaker.Add(quest);

        }
    }
}
