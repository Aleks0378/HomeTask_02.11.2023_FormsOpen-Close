using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_3.Model;
using Timer = System.Windows.Forms.Timer;

namespace Task_3
{
    public partial class QuestionForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private int currentQuestionIndex;
        private int currentAmount;
        private int timerSeconds;
        private Timer timer;
        public QuestionForm()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            // Загрузка вопросов (ваша реализация)
            LoadQuestions();

            // Инициализация переменных
            currentQuestionIndex = 0;
            currentAmount = 0;
            timerSeconds = 30;

            // Создание таймера
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            // Настройка интерфейса
            UpdateQuestion();
        }

        private void LoadQuestions()
        {
            // Загрузка вопросов из базы данных, файла и т.д.
            // Пример:
            questions = new List<Question>
            {
                new Question("Какой язык программирования вы используете?", new List<string> {"C#", "Java", "Python", "JavaScript"}, 0),
                new Question("Какая столица Франции?", new List<string> {"Лондон", "Берлин", "Париж", "Мадрид"}, 2),
                // Добавьте другие вопросы
            };
        }

        private void UpdateQuestion()
        {
            // Отображение вопроса и вариантов ответов на форме
            currentQuestion = questions[currentQuestionIndex];
            lblQuestion.Text = currentQuestion.QuestionText;

            // Перемешивание вариантов ответов
            currentQuestion.ShuffleAnswers();
            radioBtnAnswer1.Text = currentQuestion.Answers[0];
            radioBtnAnswer2.Text = currentQuestion.Answers[1];
            radioBtnAnswer3.Text = currentQuestion.Answers[2];
            radioBtnAnswer4.Text = currentQuestion.Answers[3];

            // Обновление суммы выигрыша
            lblAmount.Text = $"Текущая сумма: {currentAmount:C0}";

            // Запуск таймера
            timerSeconds = 30;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Обновление отображения таймера
            lblTimer.Text = $"Осталось времени: {timerSeconds} сек";
            timerSeconds--;

            // Проверка времени
            if (timerSeconds < 0)
            {
                EndGame("Время вышло! Игра окончена!");
            }
        }

        private void EndGame(string message)
        {
            // Завершение игры, вывод сообщения
            timer.Stop();
            MessageBox.Show(message, "Конец игры");
            Close();
        }
        private void CheckAnswer(int selectedAnswer)
        {
            // Проверка выбранного ответа
            if (currentQuestion.CorrectAnswerIndex == selectedAnswer)
            {
                // Правильный ответ
                currentAmount += currentQuestion.Amount;
                if (currentQuestionIndex == questions.Count - 1)
                {
                    EndGame("Поздравляем, вы выиграли миллион!");
                }
                else
                {
                    currentQuestionIndex++;
                    UpdateQuestion();
                }
            }
            else
            {
                // Неправильный ответ
                EndGame($"Неправильный ответ! Ваш выигрыш: {currentAmount:C0}");
            }
        }

        // Обработчики событий для кнопок ответов
        private void radioBtnAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void radioBtnAnswer2_CheckedChanged(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void radioBtnAnswer3_CheckedChanged(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void radioBtnAnswer4_CheckedChanged(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }




    }
}
