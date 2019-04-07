using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    //It can be accessible from any assembly that refers it.
    public class ClassInheritanceConcept
    {
    }

    //Public class can be accessed, inherited from every project but can not be instantiated.
    public  class BaseClass
    {
       private int Id { get; set; }
       internal string Name { get; set; }

        //To override a method you need to mark it as virtual in parent class.
       public virtual void Print()
       {
            Console.WriteLine("This is from base class.");
       }
    }

    //It is accessible only in this assembly and can not be inherited.
    internal sealed class ChildClass1 : BaseClass
    {
        public int ChildID { get; set; }
        public string ChildName { get; set; }

        //This is called method overriding.
        public override void Print()
        {
            Console.WriteLine("This is from first child class.");
        }
    }

    internal sealed class ChildClass2 : BaseClass
    {
        public int ChildID { get; set; }
        public string ChildName { get; set; }

        //This is called method hiding. 'New' keyword will actually hide child class method from base class.
        public new void Print()
        {
            Console.WriteLine("This is from second child class.");
        }
    }


}
