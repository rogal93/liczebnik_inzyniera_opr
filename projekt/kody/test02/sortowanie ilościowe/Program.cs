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
            Console.Title = "Test nr 2";
            Process proces = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"..\..\Program\Liczebniki.exe",
                    Arguments = @".\ wartosciami"
                }
            };
         
            proces.Start();
            proces.WaitForExit();

            if (SprawdzenieSortowania() == 0 && proces.ExitCode == 0)
            {
                Console.WriteLine("Wynik testu: 0");
            }
            else
            {
                Console.WriteLine("Wynik testu: 1");
            }
            Console.WriteLine("\nAutorzy:\n\tMartyna Grotek, Agata Kacprzak, Anna Chomicz, Daniel Brzeziński,\n\tHubert Pietruczuk, Damian Roguski, Patryk Moreń, Filip Oraczewski");
            Console.WriteLine("\nProgram został stworzony na warunkach Powszechnej Licencji Publicznej GNU,\nwydanej przez Fundację Wolnego Oprogramowania - według wersji 2-giej tej\nLicencji lub którejś z późniejszych wersji.");
            Console.ReadKey();
        }

        public static int SprawdzenieSortowania()
        {

            int wynik = 1; // jeżeli posortowane dobrze to 0 a jak źle to 1
            StreamReader sw_wyjscie = new StreamReader(@".\plik_wejsciowy_liczebniki_glowne.txt");
            StreamReader sw_wzorzec = new StreamReader(@".\wzorzec.txt");
            string linia1;
            string linia2;

            while ((linia1=sw_wyjscie.ReadLine())!=null&&(linia2=sw_wzorzec.ReadLine())!=null)
            {
                
                if (linia1==linia2)
                {
                    wynik = 0;
                }
                else
                {
                    wynik = 1;
                    break;
                }

            }
            sw_wyjscie.Close();
            sw_wzorzec.Close();

            return wynik;
        }
    }
}
