using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Stwórz klasę blok z polem iloscPieter typu int (odpowiada za ilość pięter w blok) oraz senior typu bool 
//(odpowiada za informację czy w bloku mieszkają osoby starsze). Dodaj w niej metodą CzyWinda(), 
//która w zależności od liczby pięter i od tego czy w budynku mieszkają seniorzy będzie wyświetlała łańcuch o konieczności zbudowania windy.
//Następnie stwórz obiekt z dowolnymi parametrami. Na ekranie wyświetl informację czy w danym budynku winda jest potrzebna czy nie.
namespace ConsoleApp2
{
    class Blok
    {
        public int iloscPieter=5;
        public bool senior=true;
        public void czyWinda()
        {
            if(this.iloscPieter>3 && senior==true)
            {
                Console.WriteLine("Winda musze byc zdudowana");
            }
            else
            {
                Console.WriteLine("Nie ma potrzeby");
            }
        }
    }
}
