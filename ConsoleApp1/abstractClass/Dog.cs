using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.abstractClass
{
    internal class Dog : AbsAnimal
    {
        public override void sleeping()
        {
            Console.WriteLine("dog is sleep in house");
        }
    }
}
