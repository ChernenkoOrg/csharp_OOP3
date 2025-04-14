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
            Console.WriteLine("Игра \"Угадай число\" \n Чтобы начать игру введите свое число");
            int input = int.Parse(Console.ReadLine());
            int tries = 2;

            Random random = new Random();
            int randomNumber = random.Next(0, 11);

            Console.WriteLine(randomNumber);

            while (tries-- > 0) {
                if (input == randomNumber)
                {
                    Console.WriteLine("Your super puper mega ultra");
                    return;
                }
                else if (input > randomNumber)
                {
                    Console.WriteLine("Загаданное число меньше");
                    input = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Загаданное число больше");
                    input = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Game over");
        }
    }
}
