using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.abstractClass
{
    // c# 추상 클래스 
    internal abstract class AbsAnimal
    {
        public abstract void sleeping();

        public void Eat() {
            Console.WriteLine("This animal is eating, do Not disturb!");
        }

    }
}
