using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ввод начальных данных
            Console.WriteLine("Игра \"Угадай число\" \nЧтобы начать игру введите диапазон одним числом (начало от 0)\nПо умолчанию 10 ");
            int quantity = 10;
            try
            {
                string quantityStr = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(quantityStr))
                {
                    throw new FormatException();
                }
                quantity = int.Parse(quantityStr);
            }
            catch (FormatException) {
                Console.WriteLine("Будет использвано значение по умолчанию 10");
            }

            //генерация рандомного числа
            Random random = new Random();
            int randomNumber = random.Next(0, quantity);
            Console.WriteLine(randomNumber);

            //подсчет попыток
            double total = 0;
            double tries = 0;
            while (total < quantity)
            {
                tries++;
                total = Math.Pow(2, tries);
            }
            tries = tries - 1;
            Console.WriteLine($"попытки: {tries}");

            Console.WriteLine("Угадывайте число:");
            int input = int.Parse(Console.ReadLine());
            tries--;


            //игра
                int lastNum = -1;
                while (tries-- > 0) {
                    if (input == randomNumber)
                    {
                        Console.WriteLine("Your super puper mega ultra!");
                        return;
                    }
                    else if (input == lastNum)
                    {
                        Console.WriteLine($"Ты лошара, введи другое число! (Последнее число: {lastNum})");
                        input = int.Parse(Console.ReadLine()); 
                        tries++; 
                        continue; 
                    }
                    else if (input > randomNumber)
                    {
                        Console.WriteLine("Загаданное число меньше.");
                        input = int.Parse(Console.ReadLine());
                        lastNum = input;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Загаданное число больше.");
                        input = int.Parse(Console.ReadLine());
                        lastNum = input;
                        continue;
                    }
                }
                Console.WriteLine("Game over");
            }
    }
}
