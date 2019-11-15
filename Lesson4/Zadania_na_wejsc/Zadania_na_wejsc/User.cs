using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_na_wejsc
{
    class User:Point 
    {
        public int level { get; set; }
        public string name { get; set; }
        public void print()
        {
            Console.WriteLine("{0},{1},{2},{3}", this.name, this.level, this.x, this.y);
        }
    }
}
