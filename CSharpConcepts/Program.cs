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
                      
            //string to int. returns boolean. If true returns result.
            string myVariable = "45";
            string anotherVariable = "Sen";
            int number = 5;
            Int32.TryParse(myVariable, out number);//manipulates number variable and returns that.
            Int32.Parse(anotherVariable);
            Console.WriteLine(number);

            //int to string.
            int numberX = 5;
            Convert.ToString(numberX);
            Console.WriteLine(numberX);




           
            Console.ReadLine();
        }
    }
}
