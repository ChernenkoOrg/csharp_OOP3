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

            IGame newGame = new GameBuilder().SetRange()
                .CalculateAttempts()
                .GenerateRandomNumber()
                .Build();

            newGame.Play();
        }
    }
}
