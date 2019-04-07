using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    //This class is generic. Methods also can be generic.
    //'<>' in this symbol you can pass the types you are going to use inside the code.
    public class ClassGenericoncept<T, Tkey, TValue>
    {
        public bool CompareWith50(T tkey)
        {
            return tkey.Equals(50);
        }

        public bool CompareTwoValues(Tkey number1, Tkey number2)
        {
            return number1.Equals(number2);
        }
        public bool CompareTwoTypes(Tkey X, TValue Y)
        {
            return X.Equals(Y);
        }
        
    }

    public class GenericAdvance<T>
    {
        public Guid Id { get; set; }
    }
}
