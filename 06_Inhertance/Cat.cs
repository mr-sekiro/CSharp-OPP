﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing.");
        }
    }

}
