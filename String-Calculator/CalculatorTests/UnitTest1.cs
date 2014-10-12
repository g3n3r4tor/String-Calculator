﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using String_Calculator;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmptyString()
        {
            // arrange
            Calculator calc = new Calculator();
            string s = "";

            // act
            int b = 0;
            

            // assert
            int a = calc.Add(s);
            Assert.AreEqual(b, a);
        }
        [TestMethod]
        public void TestOneNumber()
        {
            // arrange
            Calculator calc = new Calculator();
            string s = "1";

            // act
            int b = 1;


            // assert
            int a = calc.Add(s);
            Assert.AreEqual(b, a);
        }
        [TestMethod]
        public void TestOneRandomNumber()
        {
            // arrange
            Calculator calc = new Calculator();
            string s = "";
            Random rand = new Random();
            int rnd = rand.Next(1000);
            s = rnd.ToString();

            // act
            int b = rnd;


            // assert
            int a = calc.Add(s);
            Assert.AreEqual(b, a);
        }
        [TestMethod]
        public void TestTwoNumbers()
        {
            // arrange
            Calculator calc = new Calculator();
            string s = "1,2";

            // act
            int b = 3;


            // assert
            int a = calc.Add(s);
            Assert.AreEqual(b, a);
        }
        [TestMethod]
        public void TestTwoRandomNumbers()
        {
            // arrange
            Calculator calc = new Calculator();
            string s = "";
            Random rand = new Random();
            int rnd = rand.Next(1000);
            int rnd2 = rand.Next(1000);
            s = rnd.ToString() + "," + rnd2.ToString();
            // act
            int b = rnd + rnd2;


            // assert
            int a = calc.Add(s);
            Assert.AreEqual(b, a);
        }
        [TestMethod]
        public void TestThreeRandomNumbers()
        {
            // arrange
            Calculator calc = new Calculator();
            string s = "";
            Random rand = new Random();
            int rnd = rand.Next(1000);
            int rnd2 = rand.Next(1000);
            int rnd3 = rand.Next(1000);
            s = rnd.ToString() + "," + rnd2.ToString() + "," + rnd3.ToString();
            // act
            int b = rnd + rnd2 + rnd3;


            // assert
            int a = calc.Add(s);
            Assert.AreEqual(b, a);
        }
        [TestMethod]
        public void TestSixRandomNumbers()
        {
            // arrange
            Calculator calc = new Calculator();
            string s = "";
            Random rand = new Random();
            int rnd = rand.Next(1000);
            int rnd2 = rand.Next(1000);
            int rnd3 = rand.Next(1000);
            int rnd4 = rand.Next(1000);
            int rnd5 = rand.Next(1000);
            int rnd6 = rand.Next(1000);
            s = rnd.ToString() + "," + rnd2.ToString() + "," + rnd3.ToString() + "," + rnd4.ToString() 
                + "," + rnd5.ToString() + "," + rnd6.ToString();
            // act
            int b = rnd + rnd2 + rnd3 + rnd4 + rnd5 + rnd6;


            // assert
            int a = calc.Add(s);
            Assert.AreEqual(b, a);
        }
        [TestMethod]
        public void TestNaN()
        {
            // arrange
            Calculator calc = new Calculator();
            string s = "This is NaN";

            // act
            bool thrown = false;

            try
            {
                calc.Add(s);
            }
            catch (Exception e)
            {
                thrown = true;
            }
            // assert
            Assert.IsTrue(thrown);

        }
        [TestMethod]
        public void Testnewlines()
        {
            // arrange
            Calculator calc = new Calculator();
            string s = "";
            Random rand = new Random();
            int rnd = rand.Next(1000);
            int rnd2 = rand.Next(1000);
            int rnd3 = rand.Next(1000);
            s = rnd.ToString() + "\n" + rnd2.ToString() + "," + rnd3.ToString();
            // act
            int b = rnd + rnd2 + rnd3;


            // assert
            int a = calc.Add(s);
            Assert.AreEqual(b, a);
        }

    }
}
