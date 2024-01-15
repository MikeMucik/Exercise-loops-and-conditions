using System;
using System.Drawing;

namespace LoopsConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1 Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100");
            //
            int countNumber = 0;
            for (int i = 0; i <= 100; i++)
            {
                bool primeNumber = true;
                if ((i == 0) || (i == 1))
                {
                    primeNumber = false;
                }
                for (int j = 2; j * j <= i; j++) // możliwe zastosowanie Math.Sqrt()
                {
                    if (i % j == 0)
                    {
                        primeNumber = false;
                    }
                }
                if (primeNumber)
                {
                    countNumber++;
                }
            }
            Console.WriteLine("w zakresie 0 – 100 mamy " + countNumber + " liczb pierwszych");
            Console.WriteLine();

            Console.WriteLine("Zadanie 2 Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.");
            //
            int integer = 0;
            do
            {
                if (integer % 2 == 0)
                {
                    Console.WriteLine(integer);
                }
                integer++;
            } while (integer < 1000);
            Console.WriteLine();

            Console.WriteLine("Zadanie 3 Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.");
            //
            int n1 = 0;
            int n2 = 1;
            Console.Write(n1 + " " + n2);
            for (int i = 0; i < 20; i++)
            {
                int c = n1 + n2;
                Console.Write(" " + c);
                n1 = n2;
                n2 = c;
            }

            Console.WriteLine();
            Console.WriteLine("\r\nZadanie 4 Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej: \r\n 1 \r\n 2 3 \r\n 4 5 6 \r\n 7 8 9 10");
            //
            Console.WriteLine("Podaj liczbę całkowitą: ");
            int number = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
                if (x == y)
                {
                    Console.WriteLine();
                    x++;
                    y = 0;
                }
                else
                {
                    y++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("\r\nZadanie 5 Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.");
            //
            int numberPower = 20;
            for (int i = 1; i <= numberPower; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }


            Console.WriteLine("\r\nZadanie 6 Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:\r\n 1 + ½ +1 / 3 + ¼ itd.");
            //
            decimal v = 0;
            for (int i = 1; i <= 20; i++)
            {
                v = v + (decimal)1.0 / i;
            }
            Console.WriteLine("\r\n" + v);

            Console.WriteLine("\r\nZadanie 7 Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszejprzekątnej o długości wprowadzonej przez użytkownika i wg wzoru: *");

            //    *
            //   ***
            //  *****
            // *******
            //*********
            // *******
            //  *****
            //   ***
            //    *

            Console.WriteLine("");

            Console.WriteLine("Podaj liczbę określającą krótszą przekątną diamentu: ");
            int diagonal = int.Parse(Console.ReadLine());

            // Rysowanie górnej części diamentu
            for (int i = 1; i <= diagonal; i += 2)
            {
                int spaces = (diagonal - i) / 2;
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                for (int l = 0; l < i; l++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            int fromHigh = diagonal % 2 == 0 ? diagonal - 1 : diagonal - 2; //warunek parzystości liczby

            // Rysowanie dolnej części diamentu
            for (int i = fromHigh; i >= 0; i -= 2)
            {
                int spaces = (diagonal - i) / 2;
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                for (int l = 0; l < i; l++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }



            Console.WriteLine("\r\nZadanie 8 Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.");
            // Np.
            //Testowe dane:
            //Abcdefg
            //Rezultat
            //Gfedcba

            Console.WriteLine("Podaj ciąg znaków");
            string stringChar = Console.ReadLine();
            int intChar = stringChar.Length - 1;
            for (int i = intChar; i >= 0; i--)
            {
                Console.Write(stringChar[i]);
            }

            Console.WriteLine("\r\nZadanie 9 Napisz program, który zamieni liczbę dziesiętną na liczbę binarną");

            Console.WriteLine("Podaj liczbę dziesiętna do przekształcenia na liczbe binarną: ");
            int numberD = int.Parse(Console.ReadLine());
            string numberB = "";
            while (numberD > 0)
            {
                numberB = (numberD % 2) + numberB;
                numberD = numberD / 2;
            }
            Console.WriteLine(numberB);

            Console.WriteLine("Zadanie 10 . Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.");

            Console.WriteLine("Program znajdzie najmniejszą wspólną wielokrotność \r\nPodaj pierwszą liczbę: ");
            int firstN = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int secondN = int.Parse(Console.ReadLine());
            int numberM = firstN * secondN;
            int k;
            int m;
            bool found = false;
            for (int i = 1; i <= numberM; i++)
            {
                k = firstN * i;
                for (int j = 1; j <= numberM; j++)
                {
                    m = secondN * j;
                    if (k == m)
                    {
                        Console.WriteLine(k);
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
        }
    }
}
