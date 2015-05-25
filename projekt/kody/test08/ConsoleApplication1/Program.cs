using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace test07
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
                    FileName = @"D:\Users\Liczebnik\PROJEKT_IO\bin\Debug\liczebniki.exe",
                    Arguments = @"D:\Users\Liczebnik\PROJEKT_IO\bin\Debug\ asdasdasd"
                }
            };
            proces.Start();
            proces.WaitForExit();
            Console.WriteLine(proces.ExitCode);
            Console.ReadKey();
        }
    }
}
