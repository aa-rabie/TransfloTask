using Transflo.Driver.Application.Services;

namespace Transflo.Driver.Application.Tests.Services
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("amin", "aimn")]
        [InlineData("ahmed rabie", "adehm abeir")]
        public void CanAlphabetize(string input, string expected)
        {
            var svc = new AlphabetizerService();

            var result = svc.Alphabetize(input);

            Assert.Equal(expected, result);
        }
    }
}