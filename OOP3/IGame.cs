using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public interface IGame
    {
        int Range { get; set; }
        int RandomNum { get; set; }
        double Attempts { get; set; }

        void Play();
    }
}
