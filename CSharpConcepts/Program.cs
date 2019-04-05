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
            ClassConcept classConcept = new ClassConcept();
            classConcept.Number1 = 10;
            classConcept.Number2 = 5;
            Console.WriteLine(classConcept.Number3);
        }
    }
}
