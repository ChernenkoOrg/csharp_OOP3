using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public interface IBuilder
    {
        IBuilder SetRange();
        IBuilder GenerateRandomNumber();
        IBuilder CalculateAttempts();
        IGame Build();
    }
}
