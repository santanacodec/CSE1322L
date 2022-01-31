using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3___Edgar_Santana
{
    class Question
    {
        private string question;
        private string answer;
        private int difficulty;

        public Question(string question, string answer, int difficulty)
        {
            this.question = question;
            this.answer = answer;
            this.difficulty = difficulty;
        }

        public string getQuestion()
        {
            return question;
        }

        public string getAnswer()
        {
            return answer;
        }

        public int getDifficulty()
        {
            return difficulty;
        }

        public void setQuestion(string question)
        {
            this.question = question;
        }

        public void setAnswer(string answer)
        {
            this.answer = answer;
        }

        public void setDifficulty(int difficulty)
        {
            this.difficulty = difficulty;
        }
    }
}
