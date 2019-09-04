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

        public double Add(double addend)
        {
            return addend + Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            return Accumulator- subtractor;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            return multiplier * Accumulator;
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
