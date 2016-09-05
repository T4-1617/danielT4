using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitUppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du i förnamn?");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Vad heter du i efternamn?");
            string LastName = Console.ReadLine();

            Console.WriteLine("Hej " + LastName);
        }
    }
}
