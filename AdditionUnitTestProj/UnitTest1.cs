﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAdditionProj;


namespace AdditionUnitTestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            int expected = 9;
            Program p1 = new Program();
            int actual = p1.Addition(2, 7);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMultiplication()
        {
            int expected = 1;
            Program p1 = new Program();
            int actual = p1.Multiplication(2, 7);
            Assert.AreEqual(expected, actual);
        }
    }
}
