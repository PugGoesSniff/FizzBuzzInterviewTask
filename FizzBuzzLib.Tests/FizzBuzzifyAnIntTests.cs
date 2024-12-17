namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestPlatform.Utilities;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {
        //Testing FizzBuzzifyAnInt to see if the function returns what is expected when it recieves a multiple of 15
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAMultipleOf15()
        {
            var fizzBuzzer = new FizzBuzz();
            string returnValue = fizzBuzzer.FizzBuzzifyAnInt(30); //Test 15, should return FizzBuzz
            returnValue.Should().Be("FizzBuzz");
        }

        //Testing FizzBuzzifyAnInt to see if the function returns what is expected when it recieves a multiple of 5
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAMultipleOf5()
        {
            var fizzBuzzer = new FizzBuzz();
            string returnValue = fizzBuzzer.FizzBuzzifyAnInt(10); //Test 5, should return Buzz
            returnValue.Should().Be("Buzz");
        }

        //Testing FizzBuzzifyAnInt to see if the function returns what is expected when it recieves a multiple of 3
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAMultipleOf3()
        {
            var fizzBuzzer = new FizzBuzz();
            string returnValue = fizzBuzzer.FizzBuzzifyAnInt(6); //Test 3, should return Fizz
            returnValue.Should().Be("Fizz");
        }

        //Testing FizzBuzzifyAnInt to see if the function returns what is expected when it does not recieve a multiple of 3 or 5
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedNoMultiple()
        {
            var fizzBuzzer = new FizzBuzz();
            string returnValue = fizzBuzzer.FizzBuzzifyAnInt(4); //Test 4, should return 4 as a String
            returnValue.Should().Be("4");
        }

        //Testing FizzBuzzifyAnInt to see if the function returns what is expected when it recieves a negative number
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedNegative()
        {
            var fizzBuzzer = new FizzBuzz();
            string returnValue = fizzBuzzer.FizzBuzzifyAnInt(-4); //Test -4, should return -4 as a String
            returnValue.Should().Be("-4");
        }

        //Testing FizzBuzzifyAnInt to see if the function returns what is expected when it recieves a negative multiple
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedNegativeMultiple()
        {
            var fizzBuzzer = new FizzBuzz();
            string returnValue = fizzBuzzer.FizzBuzzifyAnInt(-3); //Test -3, should return Fizz as a String
            returnValue.Should().Be("Fizz");
        }
    }
}
