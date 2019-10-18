
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int netto,brutto;
            int podatek;
            Console.WriteLine("Podaj wartosc netto i podatek: ");
            netto = Convert.ToInt32(Console.ReadLine());
            podatek = Convert.ToInt32(Console.ReadLine());
            brutto = netto*(1+podatek)/100;
            Console.WriteLine("{0} netto  to {1} brutto", netto, brutto);

            Console.ReadKey();
        }
    }
}
