﻿using System;
using TempElementsLib.src.Classes;

namespace TempElementsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Zadanie1CheckUsing();

            Program.CheckWithTryAndCatch();
        }
        #region USING
        static void Zadanie1CheckUsing()
        {

            Program.DisplayBeginTestLine("Zad 1Check using");

            using (TempFile file = new TempFile())
            {
                Console.WriteLine("Sprawdz czy plik się utworzył");
                Console.ReadLine();
                Console.WriteLine("Sprawdz czy dane wpisały się do pliku");

                file.AddText("[1]");

                Console.ReadLine();
                Console.WriteLine("W tym momencie plik powinien się usunąć..");

            }

            Program.DisplayEndTestLine();

        }
        #endregion


        static void CheckWithTryAndCatch()
        {
            Program.DisplayBeginTestLine("Zadanie 1 Check try and catch");

            TempFile file = new TempFile();
            try
            {
                Console.WriteLine("Dodawanie tekstu do pliku, sprawdz czy tekst sie dodał");
                file.AddText("TEST");
                Console.ReadLine();
                Console.WriteLine("Usuwanie pliku, a nastepnie próba dodania tekstu do pliku");
                file.Dispose();

                file.AddText("Ten tekst nie zostanie dodany");

            }
            catch (ObjectDisposedException e)
            {
                Console.WriteLine($"{e} Plik został już usunięty, nie można wpisać danych do pliku.");
            }

            Program.DisplayEndTestLine();

        }

        static void DisplayBeginTestLine(string testName)
        {
            Console.WriteLine($"-- {testName} --");
        }

        static void DisplayEndTestLine()
        {
            Console.Write("-- ** --");
        }
    }
}
