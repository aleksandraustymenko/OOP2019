using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_na_wejsc
{
    class Tree:MapElement
    {
        public Tree()
        {
            this.icon = 'T';
        }
        public void print()
        {
            Console.WriteLine("To jest drzewo x- {0},y- {1}", this.x, this.y);
        }
    }
}
