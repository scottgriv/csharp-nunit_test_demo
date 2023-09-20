using System.Security.Cryptography;

namespace NUnit_Demo.Tests
{
    [TestFixture]
    public class Tests
    {
        bool breakTests = false; // To show failures in the unit tests, change this to true

        [Test]
        public void TestRandomNumberGeneration()
        {
            RandomNumberGenerator generator = new RandomNumberGenerator();

            // Generate random numbers and check if they are within the specified range
            for (int i = 0; i < 100; i++)
            {
                int randomNumber = generator.GenerateRandomNumber(1, 100);
                Assert.GreaterOrEqual(randomNumber, 1);
                Assert.LessOrEqual(randomNumber, 100);
            }
        }

        [Test]
        public void TestEvenOddChecker()
        {
            EvenOddChecker checker = new EvenOddChecker();

            // Test even numbers
            Assert.IsTrue(checker.IsEven(2));
            Assert.IsTrue(checker.IsEven(4));
            Assert.IsTrue(checker.IsEven(0));
            Assert.IsTrue(checker.IsEven(-2));

            // Test odd numbers
            Assert.IsTrue(checker.IsOdd(1));
            Assert.IsTrue(checker.IsOdd(3));
            Assert.IsTrue(checker.IsOdd(-1));

            // Test even/odd combinations
            Assert.IsFalse(checker.IsEven(3));
            Assert.IsFalse(checker.IsOdd(2));
        }

        [Test]
        public void TestCustomFailureCondition()
        {
            int result = breakTests ? 1 : 0;

            // Intentionally fail the test if the result is not zero
            Assert.AreEqual(0, result, "Expected result to be zero.");
        }
    }

}