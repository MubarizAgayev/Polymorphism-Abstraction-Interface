﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmClassTask.Models
{
    internal sealed class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Test()
        {
            Console.WriteLine("Seald class");
        }
    }
}
