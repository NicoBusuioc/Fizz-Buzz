using System;
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
        }


        [TestMethod]
        public void InputNumberIsDivisible_With3And5_ReturnsFizzBuzz()
        {
            //arrange
            int inputNumber = 15;


            //act
            // instanciate non-static class of FizzBuzz to be able to verify it:
            var result = _fizzBuzz.FizzBuzzConversion(inputNumber);


            //assert 
            Assert.AreEqual(FIZZBUZZ, result);
        }

        [TestMethod]
        public void InputNumberIsDivisible_With3_ReturnsFizz()
        {
            int inputNumber = 3;

            var result = _fizzBuzz.FizzBuzzConversion(inputNumber);

            Assert.AreEqual(FIZZ, result);
        }

        [TestMethod]
        public void InputNumberIsDivisible_With5_ReturnsBuzz()
        {
            int inputNumber = 5;

            var result = _fizzBuzz.FizzBuzzConversion(inputNumber);

            Assert.AreEqual(BUZZ, result);
        }

        [TestMethod]
        public void InputNumberContains_3And5_ReturnsFizzBuzz()
        {
            int inputNumber = 53;
            //int inputNumber = 35;

            var result = _fizzBuzz.FizzBuzzConversion(inputNumber);

            Assert.AreEqual(FIZZBUZZ, result);
        }

        [TestMethod]
        public void InputNumberContains_5_ReturnsBuzz()
        {
            int inputNumber = 56;
            //int inputNumber = 51;

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

    }
}
