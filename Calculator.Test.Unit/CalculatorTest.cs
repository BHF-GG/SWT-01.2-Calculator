using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
//using Calculator;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {

        private CalculatorClass uut;

        [SetUp]
        public void Setup()
        {
            uut = new CalculatorClass();
        }

        [Test]
        public void AddOne_Plus_Two_Return3()
        {
            // Arrange

            // Act
            Assert.That(uut.Add(1,2), Is.EqualTo(3));
        }

        [Test]
        public void AddThree_Plus_MinusFive_ReturnMinusTwo()
        {
            Assert.That(uut.Add(3,-5), Is.EqualTo((-2)));
        }

        [TestCase(3, 2, 5)]
        [TestCase(4, -2, 2)]
        [TestCase(-10, 2.2, -7.8)]
        [TestCase(-9.8, -8, -17.8)]
        public void Adding_two_Numbers(double a, double b, double c)
        {
            Assert.That(uut.Add(a,b),Is.EqualTo(c));
        }

        [Test]
        public void SubtractTree_Mins_Two_ReturnOne()
        {
            Assert.That(uut.Subtract(3,2), Is.EqualTo(1));
        }

        [Test]
        public void MultiplyFour_Times_2point2_Return_8point8()
        {
            Assert.That(uut.Multiply(4,2.2),Is.EqualTo(8.8));
        }

        [Test]
        public void PowerOf_3_exp_2_return9()
        {
            Assert.That(uut.Power(3,2),Is.EqualTo(9));
        }

        // Overload test
        [TestCase(1,1,1,3)]
        [TestCase(1, 2, 3, 6)]
        [TestCase(1, -2, -3, -4)]
        [Test]
        public void Add_Three_Times_Return(double a,double b, double c,double d)
        {
            uut.Add(a);
            uut.Add(b);
            Assert.That(uut.Add(c),Is.EqualTo(d));
        }


        [TestCase(1, 1, 1, -3)]
        [TestCase(6, 2, 3, -11)]
        [TestCase(-2, -2, -3, 7)]
        [Test]
        public void Subtract_Three_Times_Return(double a, double b, double c, double d)
        {
            uut.Subtract(a);
            uut.Subtract(b);
            Assert.That(uut.Subtract(c), Is.EqualTo(d));
        }

        [TestCase(2, 2, 3, 4, 48)]
        [TestCase(4, 2, 1, 3, 24)]
        [TestCase(10, -2, 3, 3, -180)]
        [Test]
        public void Multiply_Three_Times(double a, double b, double c, double d, double e)
        {
            uut.Multiply(a, b);
            uut.Multiply(c);
            uut.Multiply(d);
            Assert.That(uut.Accumulator, Is.EqualTo(e));
        }

        [TestCase(10, 2, 5,1)]
        [TestCase(20, -2,2, -5)]
        [Test]
        public void Divide_Two_Time(double a, double b, double c, double d)
        {
            uut.Divide(a, b);
            Assert.That(uut.Divide(c), Is.EqualTo(d));
        }
    }
}
