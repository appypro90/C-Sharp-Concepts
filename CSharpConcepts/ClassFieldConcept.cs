using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class is for various types of fields, methods, parameterised constructor.
namespace CSharpConcepts
{
    //By default class is Internal if any access modifier is not mentioned.
    public class ClassFieldConcept
    {
        //All properties and methods are Encapsulated/bound in a class. It's an oops characteristic.
        

        //These are private fields of the class as there is no access modifier.
        //Through methods and constructor we can access these data.
        //There can be public/read only modifier also.
        private int _Number1;
        private int _Number2;


        //You can only get it's value and can't set it.
        //You can assign readonly field only at the time of declaration or in the constructor.       
        public readonly int GetNumber3;
        private readonly int Number4 = 15;

        
        //This is constructor. Each time an instance is created constructor gets called.
        //Multiple signature of a constructor is possible through parameter overloads.
        //You can populate private field and readonly field  through constructor.
        //It does not return anything.
        public ClassFieldConcept(int number1, int number2)
        {
            _Number1 = number1;
            _Number2 = number2;

            GetNumber3 = _Number1 + _Number2;
        }


        //These are methods. The way to access data and work with them.
        public int GetLargestNumber()
        {            
          return (GetNumber3 > Number4) ? GetNumber3 : Number4; 
        }
    }
}
