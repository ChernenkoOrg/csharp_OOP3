using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Game
    {
        public int Range { get; internal set; }
        public int RandomNum { get; internal set; }
        public double Attempts { get; internal set; }

        public Game() { }

        public void Play()
        {
            Console.WriteLine("Угадывайте число:");
            int input = int.Parse(Console.ReadLine());
            Attempts--;

            int lastNum = -1;
            while (Attempts-- > 0)
            {
                if (input == RandomNum)
                {
                    Console.WriteLine("Your super puper mega ultra!");
                    return;
                }
                else if (input == lastNum)
                {
                    Console.WriteLine($"Ты лошара, введи другое число! (Последнее число: {lastNum})");
                    Attempts++; 
                }
                else if (input > RandomNum)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число больше.");
                }

                lastNum = input;
                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Game over");
        }
    }
}
