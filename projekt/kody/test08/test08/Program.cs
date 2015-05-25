using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace test08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test nr 8";
            Process proces = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"..\..\Program\liczebniki.exe",
                    Arguments = @".\ asdasdasd"
                }
            };
            proces.Start();
            proces.WaitForExit();
            Console.WriteLine("Wynik testu: " + proces.ExitCode);
            Console.WriteLine("\nAutorzy:\n\tMartyna Grotek, Agata Kacprzak, Anna Chomicz, Daniel Brzeziński,\n\tHubert Pietruczuk, Damian Roguski, Patryk Moreń, Filip Oraczewski");
            Console.WriteLine("\nProgram został stworzony na warunkach Powszechnej Licencji Publicznej GNU,\nwydanej przez Fundację Wolnego Oprogramowania - według wersji 2-giej tej\nLicencji lub którejś z późniejszych wersji.");
            Console.ReadKey();
        }
    }
}

