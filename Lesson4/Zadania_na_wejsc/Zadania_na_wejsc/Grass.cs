using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_na_wejsc
{
    class Grass:MapElement
    {
        public Grass(double x,double y)
        {
            this.icon = 'G';
        }
        public void print()
        {
            Console.WriteLine("To jest trawa x-{0},y-{1}", this.x, this.y);
        }
    }
}
