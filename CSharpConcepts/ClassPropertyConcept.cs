using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class ClassPropertyConcept
    {
        //Usually fields with getter and setter is called property.
        private DateTime date;
        private double _seconds; 
        
        //In this way through property we can set field's value.
        public DateTime Date
        {
            get
            {
              return  date;
            }
            set
            {
                if (value.Year > 1990 && value.Year <= DateTime.Today.Year)
                    date = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public double hour
        {
            get
            {
                 return _seconds / 3600;
            }
            set
            {
                if (value <= 0 || value < 24)
                    Console.WriteLine("Value should be between 0 to 24");
                else
                    _seconds = value * 3600;
                Console.WriteLine("The value is " + _seconds + " seconds.");
            }
            
        }
        
    }
}
