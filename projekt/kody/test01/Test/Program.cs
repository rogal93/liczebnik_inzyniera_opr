using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test nr 1";
            Process proces = new Process
            {
                StartInfo = new ProcessStartInfo 
                {
                    FileName = @"..\..\Program\Liczebniki.exe",
                    Arguments = @".\ alfabetycznie"
                }
            };
            proces.Start();
            proces.WaitForExit();
            string[] plikWyjscie = File.ReadAllLines(@".\plik_wejsciowy_liczebniki_glowne.txt");
            string[] plikWzorcowy = File.ReadAllLines(@".\poprawny.txt");
            int poprawne = 0;
            if (plikWyjscie.Length == plikWzorcowy.Length)
            {
                for (int i = 0; i < plikWyjscie.Length; i++)
                {
                    if (plikWyjscie[i] != plikWzorcowy[i])
                    {
                        poprawne = 1;
                        break;
                    }
                }
            }
            else
                poprawne = 1;
            if (poprawne == 0 && proces.ExitCode == 0)
                Console.WriteLine("Wynik testu: 0");
            else
                Console.WriteLine("Wynik testu: 1");
            Console.WriteLine("\nAutorzy:\n\tMartyna Grotek, Agata Kacprzak, Anna Chomicz, Daniel Brzeziński,\n\tHubert Pietruczuk, Damian Roguski, Patryk Moreń, Filip Oraczewski");
            Console.WriteLine("\nProgram został stworzony na warunkach Powszechnej Licencji Publicznej GNU,\nwydanej przez Fundację Wolnego Oprogramowania - według wersji 2-giej tej\nLicencji lub którejś z późniejszych wersji.");
            Console.ReadKey();
        }
    }
}
