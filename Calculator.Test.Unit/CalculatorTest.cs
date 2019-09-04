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


        [TestCase(10, 2, 5)]
        [TestCase(10, 0, 0)]
        public void Devide_Two_Numbers(double a, double b, double c)
        {
            Assert.That(uut.Devide(a, b), Is.EqualTo(c));
        }
    }
}
