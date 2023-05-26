using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator_example
{
    interface ICalculate
    {
        int Plus(int number1, int number2);
        int Minus(int number1, int number2);
        int Multiple(int number1, int number2);
        int Divide(int number1, int number2);
    }
}
