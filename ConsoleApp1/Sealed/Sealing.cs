using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sealed
{
    sealed class Sealing : based
    {
        int a = 0;
        int b = 0;

        int c = 0;
        int d = 0;

        public void SealedPrint()
        {
            Console.WriteLine("it is SEALED!");
            Console.WriteLine(a + b + c + d);
        }
    }
}
