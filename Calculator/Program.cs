using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorClass
    {
        public CalculatorClass()
        {
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Add(double addend)
        {
            return addend + Accumulator;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Subtract(double subtractor)
        {
            return Accumulator- subtractor;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Multiply(double multiplier)
        {
            return multiplier * Accumulator;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Power(double exponent)
        {
            return Math.Pow(Accumulator, exponent);
        }

        public double Divide(double divisor)
        {
            return Accumulator / divisor;
        }

        static void Main(string[] args)
        {

        }
    }

    
}
