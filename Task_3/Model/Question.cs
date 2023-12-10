using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Model
{
    public class Question
    {
        public string QuestionText { get; }
        public List<string> Answers { get; private set; }
        public int CorrectAnswerIndex { get; }
        public int Amount { get; }

        public Question(string questionText, List<string> answers, int correctAnswerIndex, int amount = 1000)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
            Amount = amount;
        }

        public void ShuffleAnswers()
        {
            // Перемешивание вариантов ответов
            Random rand = new Random();
            Answers = Answers.OrderBy(a => rand.Next()).ToList();
        }
    }

}
