using System;
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
            //To clear class Field concept.
            ClassFieldConcept classFieldConcept = new ClassFieldConcept(1, 5);            
            Console.WriteLine("The sum of two numbers is " + classFieldConcept.GetNumber3);
            Console.WriteLine("The largest number is " + classFieldConcept.GetLargestNumber());

            //To clear class Property concept.
            ClassPropertyConcept classPropertyConcept = new ClassPropertyConcept();
            classPropertyConcept.Date = Convert.ToDateTime("10.12.1991");
            classPropertyConcept.hour = 25;
            Console.WriteLine(classPropertyConcept.Date);

            //To clear class inheritance concept.

            //Base class instance can point to a child class instance.
            //Base class virtual(method and property) will be overriden by child class object though variable could be of base class..
            //Example of method overriding.
            BaseClass B1 = new ChildClass1();
            B1.Print();//it will print overriden version.
            ChildClass1 C1 = new ChildClass1();
            C1.Print(); //By default it will call child class method.

            //Example of method hiding.
            BaseClass B2 = new ChildClass2();
            B2.Print();//It will print base class method.
            ChildClass2 C2 = new ChildClass2();
            C2.Print();//It will print child class method.

            //Example of Interface
            AddNumber Add = new AddNumber
            {
                Number1 = 15,
                Number2 = 10
            };
            Console.WriteLine(Add.CalculateNumber());
            SubtractNumber Sub = new SubtractNumber
            {
                Number1 = 15,
                Number2 = 10
            };
            Console.WriteLine(Sub.CalculateNumber());

            //To clear Generic concepts.

            //Primary steps.
            ClassGenericoncept<int, int, string> classGenericoncept = new ClassGenericoncept<int, int, string>();
            bool result1 = classGenericoncept.CompareWith50(51);
            bool result2 = classGenericoncept.CompareTwoValues(51, 66);
            bool result3 = classGenericoncept.CompareTwoTypes(51, "51");

            Console.WriteLine("Generic class compare with 50 - " + result1);
            Console.WriteLine("Generic class compare two values - " + result2);
            Console.WriteLine("Generic class Compare Two Types - " + result3);

            //Advance steps of Generics.
            GenericAdvance<AddNumber> genericAdvance = new GenericAdvance<AddNumber>();
            genericAdvance.Calculate = new AddNumber
            {
                Number1 = 10,
                Number2 = 15
            };
            Console.WriteLine("Advance generic number is " + genericAdvance.Calculate.CalculateNumber());

            //Partial class concept.
            PartialClassConcept PCC = new PartialClassConcept
            {
                Names = new List<string>()
            };
            PCC.Names.Add("Arpita Sen");
            string name = PCC.Names.SingleOrDefault(e => e.StartsWith("A"));
            Console.WriteLine("Partial class value is " + name);

        }
    }
}
