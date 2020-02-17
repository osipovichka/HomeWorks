using ClassWork;
using NUnit.Framework;

namespace HomeWork.Tests
{
    [TestFixture]
    public class ClassWorkTests
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        [TestCase(15, "XV")]
        [TestCase(33, "XXXIII")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(111, "CXI")]
        [TestCase(3876, "MMMDCCCLXXVI")]
        public void GetRomanNumberTest(int arabicNumber, string romanNamber)
        {
            CW cw = new CW();

            string actual = cw.GetRomanNumber(arabicNumber);

            Assert.AreEqual(romanNamber, actual);
        }
    }
}