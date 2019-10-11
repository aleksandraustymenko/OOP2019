using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Utwórz program w którym zadeklarujesz tablicę liczbową. Z użyciem pętli for wypisz wszystkie wartości z tej tablicy.
Po przecinku(np. 1,2,3…)
Każdy element w nowej linii
Od ostatniego elementu do pierwszego(odwrotna kolejność)*/
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]tab = new int[] { 5, 6, 7 };
            int a = 5;
            int b = 4;
            int x,y,z;
            x = Convert.ToInt32(Console.ReadLine());
            //y = Convert.ToInt32(Console.ReadLine());
            //z = Convert.ToInt32(Console.ReadLine());
            /*for (int i=0;i<tab.Length; i++)
            {
                Console.WriteLine(tab[i]+"\n");
            }
            if(tab.Length !=0)
            {
                for (int i=0;i<tab.Length;i++)
                   {
                      Console.Write(tab[i-1] + ", ");
                   }
                   Console.WriteLine(tab[tab]);
               
              
                
            }
            Console.Write('\n');
            for(int i=tab.Length-1;i>=0; i--)
            {
                Console.Write(tab[i]+ ", ");
            }
            Console.WriteLine("\n");
            if(a>b)
            {
                Console.WriteLine("{0} jest większa niz {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} nie jest większa niz {1}", a, b);
            }*/
           /* if(x+y>z && x+z>y && y+z>x)
            {
                Console.WriteLine("Warunek istnienia trójkąta jest spełniony");
            }
            else
            {
                Console.WriteLine("Złe.Podaj inne liczby");
            }*/
            if(x>=5 && x<=15)
            {
                while(x>=0)
                {
                   Console.WriteLine(x);
                    x--;
                }
                
            }

            Console.ReadKey();

        }
            
    }
}
