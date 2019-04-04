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
                      
            //converting string to int. returns boolean. If true returns result.
            string myVariable = "45";
            //string anotherVariable = "Sen";
            int number = 5;
            Int32.TryParse(myVariable, out number);//manipulates number variable and returns that.
            //Int32.Parse(anotherVariable);
            Console.WriteLine(number);

            //int to string.
            int numberX = 5;
            Convert.ToString(numberX);
            Console.WriteLine(numberX);

            //User Defined Variables.
            //Reference type. You need to instantiate class first before use.
            PetClass pet = new PetClass();
            pet.Type = petType.Dog;
            pet.Legs = 4;
            Console.WriteLine("A " + pet.Type + " has " + pet.Legs + " legs.");

            //Value type. You can declare and use it.
            PetStruct petStruct;
            petStruct.Type = petType.Duck;
            petStruct.Legs = 2;
            Console.WriteLine("A " + petStruct.Type + " has " + petStruct.Legs + " legs.");
           
            Console.ReadLine();
        }
    }
}
