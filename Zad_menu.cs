

using System;

class Program
{
    // Funkcja parsowania
    static int Parsowanie(string tekst)
    {
        int liczba;

        while (!int.TryParse(tekst, out liczba))
        {
            Console.WriteLine("Podaj poprawną liczbę!");
            tekst = Console.ReadLine();
        }

        return liczba;
    }

    // Funkcja obliczania silni
    static long Silnia(int n)
    {
        long wynik = 1;

        for (int i = 1; i <= n; i++)
        {
            wynik *= i;
        }

        return wynik;
    }

    // Funkcja obliczania pola prostokąta
    static int PoleProstokata(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        int wybor;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Parsowanie liczby");
            Console.WriteLine("2. Obliczanie silni");
            Console.WriteLine("3. Pole prostokąta");
            Console.WriteLine("4. Wyjście");
            Console.Write("Wybierz opcję: ");

            wybor = Parsowanie(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    Console.Write("Podaj tekst do parsowania: ");
                    string tekst = Console.ReadLine();

                    int liczba = Parsowanie(tekst);

                    Console.WriteLine("Sparsowana liczba: " + liczba);
                    break;

                case 2:
                    Console.Write("Podaj liczbę: ");
                    int n = Parsowanie(Console.ReadLine());

                    if (n >= 0 && n <= 20)
                    {
                        Console.WriteLine("Silnia wynosi: " + Silnia(n));
                    }
                    else
                    {
                        Console.WriteLine("Podaj liczbę od 0 do 20!");
                    }
                    break;

                case 3:
                    Console.Write("Podaj bok a: ");
                    int a = Parsowanie(Console.ReadLine());

                    Console.Write("Podaj bok b: ");
                    int b = Parsowanie(Console.ReadLine());

                    if (a > 0 && b > 0)
                    {
                        Console.WriteLine("Pole prostokąta wynosi: "
                            + PoleProstokata(a, b));
                    }
                    else
                    {
                        Console.WriteLine("Boki muszą być większe od 0!");
                    }
                    break;

                case 4:
                    Console.WriteLine("Koniec programu!");
                    break;

                default:
                    Console.WriteLine("Nie ma takiej opcji!");
                    break;
            }

        } while (wybor != 4);
    }
}
