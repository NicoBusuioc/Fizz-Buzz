using System;
using System.Windows;
using FizzBuzzGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFizzBuzz
{
    [TestClass]
    public class UnitTestFizzBuzz
    {
        private FizzBuzz _fizzBuzz;
        private const string FIZZBUZZ = "FizzBuzz";
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";

        [TestInitialize]
        public void Initialize()
        {
            _fizzBuzz = new FizzBuzz();
            MessageBox.Show("TestInitialize");
        }



        

        [TestMethod]
        public void InputNumberIsDivisible_With3And5_ReturnsFizzBuzz()
        {
           
            int inputNumber = 15;

            var result = _fizzBuzz.FizzBuzzConversion(inputNumber);

            Assert.AreEqual(FIZZBUZZ, result);
        }

        [TestMethod]
        public void InputNumberIsDivisible_With3_ReturnsFizz()
        {
            int inputNumber = 27;

            var result = _fizzBuzz.FizzBuzzConversion(inputNumber);

            Assert.AreEqual(FIZZ, result);
        }

        [TestMethod]
        public void InputNumberIsDivisible_With5_ReturnsBuzz()
        {
            int inputNumber = 20;

            var result = _fizzBuzz.FizzBuzzConversion(inputNumber);

            Assert.AreEqual(BUZZ, result);
        }

        [TestMethod]
        public void InputNumberContains_3And5_ReturnsFizzBuzz()
        {
            int inputNumber = 53;
           //int inputNumber = 35;  // Contains 3 and 5 --- and ---  Is dibisible with 5 --- >  returns "Fizz"

            var result = _fizzBuzz.FizzBuzzConversion(inputNumber);

            Assert.AreEqual(FIZZBUZZ, result);
        }

        [TestMethod]
        public void InputNumberContains_5_ReturnsBuzz()
        {
            int inputNumber = 56;
            //int inputNumber = 51;   // Contains 5 --- and --- Is divisible with 3 --->  returns "Fizz"

            var result = _fizzBuzz.FizzBuzzConversion(inputNumber);

            Assert.AreEqual(BUZZ, result);
        }

        [Ignore]
        public void InputNumberContains_3_ReturnsFizz()
        {
            int inputNumber = 13;

            var result = _fizzBuzz.FizzBuzzConversion(inputNumber);

            Assert.AreEqual(FIZZ, result);
        }

        [TestMethod]
        public void InputNumberHas_NoMatch_ReturnsInputNumber()
        {
            int inputNumber = 22;

            var result = _fizzBuzz.FizzBuzzConversion(inputNumber);

            Assert.AreEqual(inputNumber.ToString(), result);
        }

    }
}
