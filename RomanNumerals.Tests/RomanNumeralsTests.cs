using NUnit.Framework;

namespace RomanNumerals.Tests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        private RomanNumeralsConverter _subject;

        [OneTimeSetUp]
        public void SetUp()
        {
            _subject = new RomanNumeralsConverter();
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(568, "DLXVIII")]
        public void ThenTheCorrectRomanNumeralIsReturned(int decimalNumber, string expectedValue)
        {
            var result = _subject.Convert(decimalNumber);
            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}
