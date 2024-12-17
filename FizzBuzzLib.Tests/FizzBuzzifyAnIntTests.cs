namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestPlatform.Utilities;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {

        //A series of tests that will check if FizzBuzzifyAnInt returns what is expected
        [Theory]
        [InlineData(4, "4")] //an integer not a multiple of 3 or 5 should return itself parsed as a string
        [InlineData(6, "Fizz")] //a multiple of 3 should return Fizz
        [InlineData(10, "Buzz")] //a multiple of 5 should return Buzz
        [InlineData(30, "FizzBuzz")] //a multiple of 15 should return FizzBuzz
        [InlineData(-3, "Fizz")] //a negative multiple of 3 should return Fizz
        [InlineData(-4, "-4")] //a negative non multiple to return itself parsed as a string
        public void FizzBuzzifyAnInt_AllTests(int num, string expected)
        {
            var fizzBuzzer = new FizzBuzz();
            string returnValue = fizzBuzzer.FizzBuzzifyAnInt(num);
            returnValue.Should().Be(expected);
        }
    }
}
