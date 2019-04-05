using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class ClassConcept
    {
        public ClassConcept(int number1, int number2)
        {
            _Number1 = number1;
            _Number2 = Number2;
          
        }
        int _Number1 = 0;
        int _Number2 = 0;
        int _Number3 = 0;

        public int Number1
        {
            get
            {
                return _Number1;
            }
            set
            {
                _Number1 = value;
            }
        }
        public int Number2
        {
            get
            {
                return _Number2;
            }
            set
            {
                _Number2 = value;
            }
        }
        public int Number3
        {
            get
            {
                return _Number1 + _Number2;
            }
            
        }
        public int calculate(int a, int b)
        {
            return a + b;
        }
    }
}
