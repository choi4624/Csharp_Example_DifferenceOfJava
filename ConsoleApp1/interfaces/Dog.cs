﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.interfaces
{
    internal class Dog : Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("dog!");
        }
    }
}
