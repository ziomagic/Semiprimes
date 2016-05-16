using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemiPrime;

namespace SemiTest
{
    [TestClass]
    public class SemiprimeTests
    {
        [TestMethod]
        public void TestSemiPrimeFromRange()
        {
            SemiPrimes primes = new SemiPrimes(5);
            Assert.IsTrue(primes.GetSemiPrime(4, 10) == 4);
        }

        [TestMethod]
        public void TestIsSemiPrime()
        {
            SemiPrimes primes = new SemiPrimes(5);
            Assert.IsTrue(primes.isSemiPrime(10));
        }
    }
}
