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
            Accumulator += addend;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception();
            }
            Accumulator = a / b;
            return Accumulator;

            
            //if (b == 0)
            //{
            //    Console.WriteLine("Du kan ikke dividere med 0");
            //    return 0;
            //}

            //Accumulator = a / b;
            //return Accumulator;
        }

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            Accumulator /= divisor;
            return Accumulator;
        }

        static void Main(string[] args)
        {

        }
    }

    
}
