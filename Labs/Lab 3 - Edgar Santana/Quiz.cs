using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3___Edgar_Santana
{
    class Quiz
    {
        private List<Question> quizMaker = new List<Question>();

        public void add_question()
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

        public void remove_question()
        {
            int questionToRemove;
            int questionNum = 1;

            Console.WriteLine("These are your quiz questions: ");

            for (int i = 0; i < quizMaker.Count; i++)
            {
                Console.WriteLine(questionNum + "- " + quizMaker[i].getQuestion());
                questionNum++;
            }

            Console.WriteLine("Which question number do you want to remove?");

            questionToRemove = Convert.ToInt32(Console.ReadLine());

            quizMaker.Remove(quizMaker[questionToRemove - 1]);
        }

        public void modify_question()
        {
            int questionNum = 1;
            int questionToModify;
            string newQuestion;
            string newAnswer;
            int newDifficulty;

            Console.WriteLine("These are your quiz questions: ");

            for (int i = 0; i < quizMaker.Count; i++)
            {
                Console.WriteLine(questionNum + "- " + quizMaker[i].getQuestion());
                questionNum++;
            }

            Console.WriteLine("Which question do you want to modify?");
            questionToModify = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your new question?");
            newQuestion = Console.ReadLine();
            quizMaker[questionToModify - 1].setQuestion(newQuestion);

            Console.WriteLine("What is your new answer?");
            newAnswer = Console.ReadLine();
            quizMaker[questionToModify - 1].setAnswer(newAnswer);

            Console.WriteLine("What is your new difficulty?");
            newDifficulty = Convert.ToInt32(Console.ReadLine());
            quizMaker[questionToModify - 1].setDifficulty(newDifficulty);
        }

        public void give_quiz()
        {
            int questionNum = 1;
            string answer;
            int score = 0;

            Console.WriteLine("Here is your quiz. Goodluck!");

            for (int i = 0; i < quizMaker.Count; i++)
            {
                Console.WriteLine(questionNum + "- " + quizMaker[i].getQuestion());
                answer = Console.ReadLine();

                if(answer == quizMaker[i].getAnswer())
                {
                    score++;
                } else
                {
                    score += 0 ;
                }
                questionNum++;
            }

            Console.WriteLine("you got " + score + " correct");
        }
    }
}
