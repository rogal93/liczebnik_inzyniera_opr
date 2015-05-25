using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test nr 3";
            Stopwatch zegarek = new Stopwatch();
            Process proces = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"..\..\Program\Liczebniki.exe",
                    Arguments = @".\ wartosciami"
                }
            };
            zegarek.Reset();
            zegarek.Start();
            proces.Start();
            proces.WaitForExit();
            zegarek.Stop();
            int wyjscie = proces.ExitCode;
            Console.WriteLine(wyjscie);
            double czas = zegarek.ElapsedMilliseconds;
            
            Console.WriteLine("Czas wykonania: " + czas/1000  + " sek" );
            Console.WriteLine("\nAutorzy:\n\tMartyna Grotek, Agata Kacprzak, Anna Chomicz, Daniel Brzeziński,\n\tHubert Pietruczuk, Damian Roguski, Patryk Moreń, Filip Oraczewski");
            Console.WriteLine("\nProgram został stworzony na warunkach Powszechnej Licencji Publicznej GNU,\nwydanej przez Fundację Wolnego Oprogramowania - według wersji 2-giej tej\nLicencji lub którejś z późniejszych wersji.");
            Console.ReadKey();
        }
    }
}
