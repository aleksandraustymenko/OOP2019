using System;


namespace Lesson7
{
    class Produkt : IClonable
    {
        public string nazwa;
        public double cenaJednostkowa;
        public int ilosc;

        public Produkt(string nazwa,double cenaJednostkowa,int ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }

        public object Clone()
        {
            return (Produkt) this.MemberwiseClone();
        }
        public Produkt Clone2()
        {
            Produkt nowy = (Produkt)this.MemberwiseClone();
            nowy.nazwa = String.Copy(nazwa);
            return nowy;
        }


        
    }
}
