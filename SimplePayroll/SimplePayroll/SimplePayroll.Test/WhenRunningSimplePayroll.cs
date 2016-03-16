
using NUnit.Framework;
namespace SimplePayroll.Test
{
    [TestFixture]
    public class WhenRunningSimplePayroll
    {
        #region UserEnteredSentinelValue Tests

        [Test]
        public void When_UserEnteredSentinelValue_ResultShouldBeTrue()
        {
            var expected = true;

            var actual = Program.SentienlCheck("Q");

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredPrintValue_ResultShouldBeTrue()
        {
            var expected = true;

            var actual = Program.PrinterCheck("P");

            Assert.That(expected, Is.EqualTo(actual));
        }
        #endregion

        #region UserEnteredValue Tests
        [Test]
        public void When_UserEnteredNumber_NumberCheck_ResultShouldBeTrue()
        {
            var expected = true;

            var actual = Program.NumberCheck("1234");

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredChar_NumberCheck_ResultShouldBeFalse()
        {
            var expected = false;

            var actual = Program.NumberCheck("ssr");

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredChar_CharCheck_ResultShouldBeTrue()
        {
            var expected = true;

            var actual = Program.NameCheck("ssr");

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredNumber_CharCheck_ResultShouldBeTrue()
        {
            var expected = false;

            var actual = Program.NameCheck("12345");

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredRightSSN_SSNCheck_ResultShouldBeTrue()
        {
            var expected = true;

            var actual = Program.SSNCheck("12e3-222-df");

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredWrongSSN_SSNCheck_ResultShouldBeFalse()
        {
            var expected = false;

            var actual = Program.SSNCheck("12e3222edf");

          
            Assert.That(expected, Is.EqualTo(actual));
        }
        #endregion

        #region UserEnteredType Tests
        [Test]
        public void When_UserEnteredRightType_SE_TypeCheck_ResultShouldBeTrue()
        {
            var expected = true;

            var actual = Program.TypeCheck("SE");


            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredRightType_CE_TypeCheck_ResultShouldBeTrue()
        {
            var expected = true;

            var actual = Program.TypeCheck("CE");


            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredRightType_SBCE_TypeCheck_ResultShouldBeTrue()
        {
            var expected = true;

            var actual = Program.TypeCheck("SBCE");


            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredRightType_HE_TypeCheck_ResultShouldBeTrue()
        {
            var expected = true;

            var actual = Program.TypeCheck("HE");


            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredWrongType_HE_TypeCheck_ResultShouldBeTrue()
        {
            var expected = false;

            var actual = Program.TypeCheck("CHE");


            Assert.That(expected, Is.EqualTo(actual));
        }
        #endregion

    }
}
