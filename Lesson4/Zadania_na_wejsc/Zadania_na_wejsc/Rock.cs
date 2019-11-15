using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_na_wejsc
{
    class Rock:MapElement
    {
        public Rock()
        {
            this.icon = 'R';
        }
        public void print()
        {
            Console.WriteLine("To jest kamien x- {0},y- {1}", this.x, this.y);
        }
    }
}
