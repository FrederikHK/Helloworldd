using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellomundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Vælg 1 eller 2");
            int svar = Convert.ToInt32(Console.ReadLine());

            switch (svar)
            {
                case 1:
                    Console.WriteLine("Du har valgt 1");
                    break;
                case 2:
                    Console.WriteLine("Du har valgt 2");
                    break;
            }

            Console.Read();
        }
    }
}
