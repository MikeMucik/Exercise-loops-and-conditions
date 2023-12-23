using System;

namespace LoopsConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1 Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100
            //int countNumber = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    bool primeNumber = true;
            //    if ((i == 0) || (i == 1))
            //    {
            //        primeNumber = false;
            //    }
            //    for (int j = 2; j*j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            primeNumber = false;
            //        }
            //    }
            //    if (primeNumber)
            //    {
            //        countNumber ++;
            //    }
            //}
            //Console.WriteLine("w zakresie 0 – 100 mamy " + countNumber + " liczb pierwszych");

            //Zadanie 2 Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.
            //int i = 0;
            //do
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //} while (i < 1000);

            //Zadanie 3 Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
            //int n1 = 0;
            //int n2 = 1;
            //Console.Write(n1 + " " + n2);
            //for (int i = 0; i < 20; i++)
            //{
            //    int c = n1 + n2;
            //    Console.Write(" " + c);
            //    n1 = n2;
            //    n2 = c;
            //}

            //Zadanie 4 Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:          
            //1
            //2 3
            //4 5 6
            //7 8 9 10
            //Console.WriteLine("Podaj liczbę całkowitą: ");
            //int number = int.Parse(Console.ReadLine());
            //int x = 0;
            //int y = 0;
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(i + " ");
            //    if (x == y)
            //    {
            //        Console.WriteLine();
            //        x++;
            //        y = 0;
            //    }
            //    else
            //    {
            //        y++;
            //    }
            //}


            //Zadanie 5 Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            //int numberPower = 20;
            //    for (int i = 1; i < numberPower; i++)
            //{
            //    Console.WriteLine(Math.Pow(i, 3));
            //}
            // Zadanie 6 Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            //1 + ½ +1 / 3 + ¼ itd.
            decimal v = 0;
            for (int i = 1; i <= 20; i++)
                {
                    v = v + (decimal)1.0 / i;
                }
            Console.WriteLine(v);


            //Zadanie 7 Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
            //przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
            //*
            // ***
            // *****
            //*******
            //*********
            //*******
            // *****
            // ***
            // *



            //Zadanie 8 Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
            //Testowe dane:
            //Abcdefg
            //Rezultat
            //Gfedcba

            //Zadanie 9 Napisz program, który zamieni liczbę dziesiętną na liczbę binarną

            //Zadanie 10 . Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
        }
    }
}



