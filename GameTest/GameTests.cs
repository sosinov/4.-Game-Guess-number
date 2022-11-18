using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace GameTest
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void TestConstructorNotNull()
        {
            SecretNumber result = new SecretNumber();
            Assert.IsNotNull(result.GeneratedRandomNumber);
        }

        [TestMethod]
        public void TestConstructorIsInRange()
        {
            SecretNumber result = new SecretNumber();
            Assert.IsTrue(Enumerable.Range(0, 101).Contains(result.GeneratedRandomNumber));
        }

        [DataRow(1)]
        [DataRow(11)]
        [DataRow(100)]
        [DataRow(0)]
        [TestMethod]
        public void SecretNumberValidation_InValidRange_ValidationSuccess(int? input)
        {
            SecretNumber result = new SecretNumber();
            int expectedWin = 0;
            if (result.Validation(input) == expectedWin)
            {
                Assert.AreEqual(expectedWin, result.Validation(input));
            }
        }

        [DataRow(1)]
        [DataRow(11)]
        [DataRow(100)]
        [DataRow(0)]
        [TestMethod]
        public void SecretNumberValidation_GreatThanValidRange_ValidationFailed(int? input)
        {
            SecretNumber result = new SecretNumber();
            int expectedBigger = 1;
            if (result.Validation(input) == expectedBigger)
            {
                Assert.AreEqual(expectedBigger, result.Validation(input));
            }
        }

        [DataRow(1)]
        [DataRow(11)]
        [DataRow(100)]
        [DataRow(0)]
        [TestMethod]
        public void SecretNumberValidation_LessThanValidRange_ValidationFailed(int? input)
        {
            SecretNumber result = new SecretNumber();
            int expectedSmaller = -1;
            if (result.Validation(input) == expectedSmaller)
            {
                Assert.AreEqual(expectedSmaller, result.Validation(input));
            }
        }
    }
}