using System;
using NET.S._2020.Aristova._06;
using NUnit.Framework;

namespace TestingMethod
{
    public class PolynomialTest
    {

        [Test]
        public void OperatorPlus_P1Coefficient1234P2Coefficient12_ExpectedP3Coefficient1246()
        {
            Polynomial p1 = new Polynomial {Coefficients = new[] {1, 2, 3, 4}};
            Polynomial p2 = new Polynomial {Coefficients = new[] {1, 2}};

            Polynomial ExpextedP3 = new Polynomial {Coefficients = new[] {1, 2, 4, 6}};

            Polynomial p3 = p1 + p2;

            Assert.AreEqual(p3.Coefficients, ExpextedP3.Coefficients);
        }


        [Test]
        public void OperatorPlus_P2Coefficient32P1Coefficient12_ExpectedP3Coefficient44()
        {
            Polynomial p1 = new Polynomial {Coefficients = new[] {1, 2}};
            Polynomial p2 = new Polynomial {Coefficients = new[] {3, 2}};

            Polynomial ExpextedP3 = new Polynomial {Coefficients = new[] {4, 4}};

            Polynomial p3 = p1 + p2;

            Assert.AreEqual(p3.Coefficients, ExpextedP3.Coefficients);
        }



        [Test]
        public void OperatorPlus_P1Coefficient1P2Coefficient3_ExpectedP3Coefficient4()
        {
            Polynomial p1 = new Polynomial {Coefficients = new[] {1}};
            Polynomial p2 = new Polynomial {Coefficients = new[] {3}};

            Polynomial ExpextedP3 = new Polynomial {Coefficients = new[] {4}};

            Polynomial p3 = p1 + p2;

            Assert.AreEqual(p3.Coefficients, ExpextedP3.Coefficients);
        }

        [Test]
        public void OperatorMultiplication_P1Coefficient1P2Coefficient3_ExpectedP3Coefficient3()
        {
            Polynomial p1 = new Polynomial {Coefficients = new[] {1}};
            Polynomial p2 = new Polynomial {Coefficients = new[] {3}};

            Polynomial ExpextedP3 = new Polynomial {Coefficients = new[] {3}};

            Polynomial p3 = p1 * p2;
            Assert.AreEqual(p3.Coefficients, ExpextedP3.Coefficients);
        }


        [Test]
        public void OperatorMultiplication_P1Coefficient123P2Coefficient31_ExpectedP3Coefficient3()
        {
            Polynomial p1 = new Polynomial { Coefficients = new[] { 1, 2,3 } };
            Polynomial p2 = new Polynomial { Coefficients = new[] { 3, 1 } };

            Polynomial ExpextedP3 = new Polynomial { Coefficients = new[] { 3,7, 11, 3} };

            Polynomial p3 = p1 * p2;
            Assert.AreEqual(p3.Coefficients, ExpextedP3.Coefficients);
        }


    }
}
