using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorClass
    {
        public double Accumulator { get; private set; }

        public CalculatorClass()
        {
        }

        public double Add(double a, double b)
        {
            Accumulator =  a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }


        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public double Devide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Du kan ikke dividere med 0");
                return 0;
            }

            return a / b;
        }

        static void Main(string[] args)
        {

        }
    }

    
}
