﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassFieldConcept classFieldConcept = new ClassFieldConcept(1, 5);            
            Console.WriteLine("The sum of two numbers is " + classFieldConcept.GetNumber3);
            Console.WriteLine("The largest number is " + classFieldConcept.GetLargestNumber());

            ClassPropertyConcept classPropertyConcept = new ClassPropertyConcept();
            classPropertyConcept.Date = Convert.ToDateTime("10.12.1991");
            classPropertyConcept.hour = 25;
            Console.WriteLine(classPropertyConcept.Date);
        }
    }
}
