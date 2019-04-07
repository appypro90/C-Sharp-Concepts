using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    interface ICalculate
    {
        //by default interface members are public. No need to mention it.
        //It does not contain fields.
        int Number1 { get; set; }
        int Number2 { get; set; }

        int CalculateNumber();        
    }
    //This class needs to implement Interface.
    class AddNumber : ICalculate
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
 
        public int CalculateNumber()
        {
            return Number1 + Number2;           
        }
    }
    class SubtractNumber : ICalculate
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public int CalculateNumber()
        {
            return Number1 - Number2;
        }
    }
}
