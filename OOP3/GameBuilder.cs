using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    internal class GameBuilder : IBuilder
    {
        public enum Dificulty 
        {
            Easy,
            Medium,
            Hard
        }

        private double attempts;
        private int randomNum;
        private int range = 10;

        public IBuilder SetRange()
        {
            Console.WriteLine("Игра \"Угадай число\" \nЧтобы начать игру введите диапазон одним числом (начало от 0)\nПо умолчанию 10 ");
            try
            {
                string attemptsStr = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(attemptsStr))
                {
                    throw new FormatException();
                } 
                this.range = int.Parse(attemptsStr);
            }
            catch (FormatException)
            {
                Console.WriteLine("Будет использвано значение по умолчанию 10");
            }

            if (range <= 0)
                throw new ArgumentException("Диапазон должен быть больше 0.");
            return this;
        }

        public IBuilder CalculateAttempts()
        {
            Console.WriteLine("Выберите сложность: Easy, Medium, Hard");

            string difficultyStr = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(difficultyStr))
            {
                throw new FormatException("Сложность не может быть пустой.");
            }

            if (!Enum.TryParse(difficultyStr, out Difficulty difficulty))
            {
                throw new ArgumentException("Неверно указана сложность. Допустимые значения: Easy, Medium, Hard.");
            }

            double total = 0;
            double tries = 0;
            while (total < range)
            {
                tries++;
                total = Math.Pow(2, tries);
            }

            switch (difficulty)
            {
                case Difficulty.Easy:
                    attempts = tries; 
                    break;
                case Difficulty.Medium:
                    attempts = tries - 1; 
                    break;
                case Difficulty.Hard:
                    attempts = tries - 2; 
                    break;
            }

            if (attempts <= 0)
            {
                attempts = 1;
            }

            return this;
        }

        public IBuilder GenerateRandomNumber()
        {
            Random random = new Random();
            randomNum = random.Next(0, range);
            return this;
        }

        public Game Build()
        {
            if (randomNum == 0 || attempts == 0)
                throw new InvalidOperationException("Необходимо сгенерировать случайное число и рассчитать попытки.");

            return new Game
            {
                RandomNum = randomNum,
                Range = range,
                Attempts = attempts
            };
        }
    }
}
