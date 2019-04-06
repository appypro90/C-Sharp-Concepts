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
    public abstract class BaseClass
    {
       private int Id { get; set; }
       private string Name { get; set; }
    }

    //It is accessible only in this assembly and can not be inherited.
    internal sealed class ChildClass : BaseClass
    {
        public int ChildID { get; set; }
        public string ChildName { get; set; }
    }


}
