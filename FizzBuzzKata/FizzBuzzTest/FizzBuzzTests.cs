using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture()]
    public class FizzBuzzTests
    {
        [Test()]
        public void generateFizzBuzz()
        {
            var fizzBuzzGenerator = new FizzBuzzGenerator();
            fizzBuzzGenerator.GenerateFizzBuzz();
        }
    }
}
