﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Manager
{
    internal class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"University {this.Name} with Id {this.Id}");
        }
    }
}
