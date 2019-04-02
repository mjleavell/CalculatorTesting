using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    // by default classes are internal
    public class CalculationEngine
    {
        //define method in simplest way possible
        public int DoMath(string stuffToCalculate)
        {
            // throw new NotImplementedException();
            // return 0;
            //return 4;

            // code below is before refactor ----this is way more readable and better test
            //var splitNumbers = stuffToCalculate.Split('+');
            //int firstNumber = int.Parse(splitNumbers[0]);
            //int secondNumber = int.Parse(splitNumbers[1]);

            //return firstNumber + secondNumber;


            // REFACTORED Code
            var splitNumbers = stuffToCalculate.Split('+')
                .Select(int.Parse).ToArray();

            return splitNumbers[0] + splitNumbers[1];
        }
    }
}
