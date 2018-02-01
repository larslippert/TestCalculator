using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClass _calc = new CalculatorClass();
            Console.WriteLine("{0} + {1} = {2}", 4, 9, _calc.Add(4,9));
        }
    }
}
