using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inherit
{
    // 자식 함수 - Parent
    internal class ChildClass : ParentClass
    {
        public void ChildMethod()
        {
            Console.WriteLine("Child Method");
        }
    }
}
