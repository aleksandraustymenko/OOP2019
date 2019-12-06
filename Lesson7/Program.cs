using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplikacja kupujacy= new Aplikacja();
            kupujacy.WczytajDane();
            kupujacy.WykonajDzialania();

        }
    }
}
