using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja3_2023_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //używamy zmiennych do opisania postaci z filmu/gry
            // TYP nazwa = wartość;
            string nazwaPostaci = "anty-terrorysta";
            int wiekPostaci = 30;
            double zdrowiePostaci = 100;
            string wypozarzeniePostaci = "AK47";
            decimal pieniadzePostaci = 1300m;
            float wzrostPostaci = 1.8f;
            bool czyPostacJestDobra = true;
            char plecPostaci = 'm';

            //Kontkatenacja
            Console.WriteLine("Nazwa postaci: "+nazwaPostaci+"| Wyposażenie postaci: "+wypozarzeniePostaci);
            Console.WriteLine("Fundusze postaci: " + pieniadzePostaci+"| Zdrowie postaci: "+ zdrowiePostaci);

            //Interpolacja
            Console.WriteLine($"Nazwa postaci: {nazwaPostaci}| Wyposażenie postaci: {wypozarzeniePostaci}");
            Console.WriteLine($"Fundusze postaci: {pieniadzePostaci}| Zdrowie postaci {zdrowiePostaci}");

            //Metoda argumentowa
            Console.WriteLine("Nazwa postaci: {0}| Wyposażenie postaci: {1}", nazwaPostaci, wypozarzeniePostaci);
            Console.WriteLine("Fundusze postaci: {0}| Zdrowie postaci: {1}", pieniadzePostaci, zdrowiePostaci);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Matma");

            int a = 5;
            int b = 10;
            int c = 4;

            //dodawanie
            int suma = a + b + c;
            Console.WriteLine(suma);

            //odjemowanie
            int roznica = b - a - c;
            Console.WriteLine(roznica);

            //mnożenie
            int iloczyn = a * b * c;
            Console.WriteLine(iloczyn);

            //dzielenie
            int iloraz = b / a;
            Console.WriteLine(iloraz);

            //reszta z dzielenia - modulo
            int modulo = b % c;   // 10 / 4 = 2  r2
            Console.WriteLine(modulo);

            //kolejność wykonywania działań
            int kwd = (a + b) * c / (a + b);
            
            //dokładność -> int NIE przechowuje części ułamkowych!!!
            int x = b / c;
            Console.WriteLine($"{b}/{c}={x}");

            double b2 = 10;
            double c2 = 4;
            double x2 = b2 / c2;
            Console.WriteLine($"{b2}/{c2}={x2}");

            Console.ReadLine();
            Console.Clear();

            //Jak przechwycić dane z konsoli?
            Console.WriteLine("Jak masz na imie?");
            string imie = Console.ReadLine();

            Console.WriteLine($"Twoje imię to {imie}");

            //WSZYSTKO CO USER WPISUJE W KONSOLI TO STRING
            Console.WriteLine("Podaj mi swój wiek");
            int wiek = int.Parse(Console.ReadLine());

            Console.WriteLine($"Twój wiek to {wiek}");

            Console.ReadLine();
            Console.Clear();

            //Chcemy obliczyć pole trapezu na podstawie danych podanych przez użutkownika
            // P = (a+b)*h/2
            Console.WriteLine("Podaj długość pierwszej podstawy");
            double podstawa1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość drugiej podstawy");
            double podstawa2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokość");
            double wysokość = double.Parse(Console.ReadLine());

            double pole = (podstawa1 + podstawa2) * wysokość / 2;
            Console.WriteLine($"Pole trapezu wynosi: {pole}");

            //KLASA MATEMATYCZNA

            //Potęgowanie
            Console.WriteLine(Math.Pow(2,15));

            // pierwiastek z 4 = 2
            Console.WriteLine(Math.Sqrt(4)); 

            //stała PI
            Console.WriteLine(Math.PI);

            Console.ReadLine();
        }
    }
}
