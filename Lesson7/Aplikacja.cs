using System;
using System.Linq;


namespace Lesson7
{
    class Aplikacja:Koszyk
    {
        public static ConsoleKey klawisz;

        public void WczytajDane()
        {
            Console.WriteLine("Dzień dobry!");
            Console.WriteLine("Co chcesz zrobić? Naciśnij odpowiedni klawisz");
            Console.WriteLine("Legenda: ");
            Console.WriteLine("P - dodaj produkt do koszyka");
            Console.WriteLine("K - skopiuj ostatnio wprowadzony produkt");
            Console.WriteLine("Z - pokaz zawartosc koszyka");
            Console.WriteLine("S - pokaz sumę do zapłaty");
            Console.WriteLine("X - skasuj produkt z listy(musisz znać numer na liście)");
            Console.WriteLine("W - wydrukuj paragon");
            Console.WriteLine("N - dodaj nowy koszyk");
            Console.WriteLine("E - zakończ działanie programu");
            klawisz = Console.ReadKey().Key;
            Console.WriteLine();
        }
        public void WykonajDzialania()
        {
            switch (klawisz)
            {
                case ConsoleKey.P:
                    {
                        Console.WriteLine("Podaj nazwe: ");
                        string nazwa = Console.ReadLine();
                        Console.WriteLine("Podaj cenę:");
                        double cena = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj ilosc: ");
                        int ilosc = int.Parse(Console.ReadLine());

                        Zakupy.Add(new Produkt(nazwa, cena, ilosc));
                        Console.WriteLine($"Dodano {nazwa}");
                        break;
                    }
                case ConsoleKey.K:
                    {
                        Zakupy.Add(Zakupy.Last().Clone2());
                        break;
                    }
                case ConsoleKey.Z:
                    {
                        int numer = 0;
                        foreach (var zm in Zakupy)
                        {
                            Console.WriteLine($"{numer++}. {zm.nazwa}-{zm.cenaJednostkowa}/{zm.ilosc}");
                        }
                        
                        break;
                    }
                case ConsoleKey.S:
                    {
                        double suma = 0;
                        foreach (var zm in Zakupy)
                        {
                            suma += zm.cenaJednostkowa * zm.ilosc;
                        }
                        Console.WriteLine($"Zaplacisz za produkty:{suma}");
                        break;
                    }
                case ConsoleKey.X:
                    {
                        Console.WriteLine("Podaj numer na liscie");
                        int numer = int.Parse(Console.ReadLine());
                        Zakupy.RemoveAt(numer);
                        Console.WriteLine($"Produkt pod numerem {numer} zostal usunienty");
                        break;
                    }
                case ConsoleKey.W:
                    {
                        string zapisz = "";
                        double suma = 0;
                        DateTime aktualna = DateTime.Now;
                        string Data = aktualna.ToString("ddMMyyyyHHmmss.txt");
                        foreach (var zm in Zakupy)
                        {
                            zapisz += String.Format($"{zm.nazwa}-{zm.cenaJednostkowa}--{zm.ilosc}  ");
                            suma += zm.cenaJednostkowa * zm.ilosc;
                        }
                        zapisz += String.Format($" Suma do platy:{suma}");

                        Zakupy.Clear();
                        Console.WriteLine("Koszyk pusty");
                        break;
                    }
                case ConsoleKey.N:
                    {
                        Zakupy.Clear();
                        Console.WriteLine("Koszyk pusty");
                        break;

                    }
                case ConsoleKey.E:
                    {
                        Environment.Exit(0);
                        return;
                    }
            }
        }
        protected internal void Koniec()
        {
            Console.WriteLine("Wciśni dowolny klawisz ,żeby zakończyć program");
            Console.ReadKey();
            Console.Clear();
        }
    }

}
