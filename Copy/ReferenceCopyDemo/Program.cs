﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceCopyDemo
{
    class Demo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Print(string objectName)
        {
            Console.WriteLine($"Object Name- {objectName} \nFirst Name- {FirstName} \nLast Name- {LastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            d1.FirstName = "Peter";
            d1.LastName = "Parker";
            d1.Print("d1");

            Demo d2 = new Demo();
            d2 = d1;
            d2.FirstName = "Rachel";
            d2.Print("d2");
            d1.Print("d1");

            Console.ReadLine();
        }
    }
}
