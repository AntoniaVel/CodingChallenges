using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostcodeParser;

namespace TestPostcodeParser
{
    [TestClass]
    public class TestProblemTwo
    {
        private readonly ProblemTwo _problemTwo;

        public TestProblemTwo()
        {
            _problemTwo = new ProblemTwo();
        }

        [TestMethod]
        public void TestValidPostCode()
        {
            _problemTwo.PostCode = "M28 7JP";
            var expectedResult = "# POSTCODE: M287JP\n\tOUTWARD CODE: M28\n\t\tOUTWARD LETTER: M\n\t\tOUTWARD NUMBER: 28\n\tINWARD CODE: 7JP\n";

            bool result = _problemTwo.PostCodeParser() == expectedResult;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestLowerCasePostCode()
        {
            _problemTwo.PostCode = "wc2H7dE";
            var expectedResult = "# POSTCODE: WC2H7DE\n\tOUTWARD CODE: WC2H\n\t\tOUTWARD LETTER: WC\n\t\tOUTWARD NUMBER: 2H\n\tINWARD CODE: 7DE\n";

            bool result = _problemTwo.PostCodeParser() == expectedResult;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSpacesPostCode()
        {
            _problemTwo.PostCode = "CT21    4LR";
            var expectedResult = "# POSTCODE: CT214LR\n\tOUTWARD CODE: CT21\n\t\tOUTWARD LETTER: CT\n\t\tOUTWARD NUMBER: 21\n\tINWARD CODE: 4LR\n";

            bool result = _problemTwo.PostCodeParser() == expectedResult;

            Assert.IsTrue(result);
        }
    }
}
