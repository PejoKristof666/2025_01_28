using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _2025_01_28;

namespace _2025_01_28_testPart
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstZero()
        {
            int num = 0;
            int expected = 0;
            Multiply a = new Multiply();
            int result = a.Valami(num);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestFirstNegative()
        {
            int num = -5;
            int expected = -25;
            Multiply a = new Multiply();
            int result = a.Valami(num);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestFirstPositive()
        {
            int num = 5;
            int expected = 25;
            Multiply a = new Multiply();
            int result = a.Valami(num);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void TestSecondTypeA()
        {
            int numB = 3;
            int numC = 7;
            double expected = 3.3;
            Multiply b = new Multiply();
            double result = b.masikValami(numB, numC);
            Assert.AreEqual(expected, result, 0.3);
        }
        [TestMethod]
        public void TestSecondTypeB()
        {
            int numB = 8;
            int numC = 5;
            double expected = 2.6;
            Multiply b = new Multiply();
            double result = b.masikValami(numB, numC);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSecondTypeC()
        {
            int numB = 9;
            int numC = 9;
            double expected = 2;
            Multiply b = new Multiply();
            double result = b.masikValami(numB, numC);
            Assert.AreEqual(expected, result, 0.3);
        }
        [TestMethod]
        public void TestSecondTypeD()
        {
            int numB = 4;
            int numC = 2;
            double expected = 3;
            Multiply b = new Multiply();
            double result = b.masikValami(numB, numC);
            Assert.AreEqual(expected, result, 0.3);
        }


        [TestMethod]
        public void TestThirdZero()
        {
            int num = 0;
            int expected = 0;
            OtherClass c = new OtherClass();
            int result = c.Valami(num);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestThirdNegative()
        {
            int num = -5;
            int expected = -35;
            OtherClass c = new OtherClass();
            int result = c.Valami(num);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestThirdPositive()
        {
            int num = 5;
            int expected = 35;
            OtherClass c = new OtherClass();
            int result = c.Valami(num);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void TestForth()
        {
            double num1 = 2.3;
            double num2 = 1.5;
            double num3 = 5.1;
            double expected = 8.9;
            OtherClass d = new OtherClass();
            double result = d.ThreeParameter(num1, num2, num3);
            Assert.AreEqual(expected, result, 0.1);
        }
    }
}
