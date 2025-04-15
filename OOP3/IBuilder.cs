using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal interface IBuilder
    {
        IBuilder SetRange();
        IBuilder GenerateRandomNumber();
        IBuilder CalculateAttempts();
        Game Build();
    }
}
