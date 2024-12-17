namespace FizzBuzzLib.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestPlatform.Utilities;
    using Xunit;

    public class FizzBuzzifyAnIntWithDictionaryTests
    {
        //Testing FizzBuzzifyAnInt to see if the function returns what is expected when it recieves default dictionary
        [Fact]
        public void FizzBuzzifyAnInt_WhenUsingDefaultDictionary()
        {
            var fizzBuzzer = new FizzBuzz();
            //list of strings that need to be compared with expected
            List<string> returnedStrings = new List<string>() { };
            //Test 1-10 inclusively
            for (int i = 1; i <= 10; i++)
            {
                returnedStrings.Add(fizzBuzzer.FizzBuzzifyAnInt(i));
            }
            List<string> expectedStrings = new List<string>() {"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz" };
            //Check each value to make sure it is what is expected
            for (int i = 0; i < 10; i++)
            {
                returnedStrings[i].Should().Be(expectedStrings[i]);
            }
        }

        //Testing FizzBuzzifyAnInt to see if it returns what is expected with the even dictionary
        [Fact]
        public void FizzBuzzifyAnInt_WhenUsingEvenDictionary()
        {
            var fizzBuzzer = new FizzBuzz(new Dictionary<int, string>() { { 2, "Even" } });
            //list of strings that need to be compared with expected
            List<string> returnedStrings = new List<string>() { };
            //Test 1-10 inclusively
            for (int i = 1; i <= 10; i++)
            {
                returnedStrings.Add(fizzBuzzer.FizzBuzzifyAnInt(i));
            }
            List<string> expectedStrings = new List<string>() { "1", "Even", "3", "Even", "5", "Even", "7", "Even", "9", "Even" };
            //Check each value to make sure it is what is expected
            for (int i = 0; i < 10; i++)
            {
                returnedStrings[i].Should().Be(expectedStrings[i]);
            }
        }

        //Testing FizzBuzzifyAnInt with the duck oriented dictionary
        [Fact]
        public void FizzBuzzifyAnInt_WhenUsingDuckDictionary()
        {
            var fizzBuzzer = new FizzBuzz(new Dictionary<int, string>() { { 2, "Quack" }, { 5, "Honk" } });
            //list of strings that need to be compared with expected
            List<string> returnedStrings = new List<string>() { };
            //Test 1-10 inclusively
            for (int i = 1; i <= 10; i++)
            {
                returnedStrings.Add(fizzBuzzer.FizzBuzzifyAnInt(i));
            }
            List<string> expectedStrings = new List<string>() { "1", "Quack", "3", "Quack", "Honk", "Quack", "7", "Quack", "9", "QuackHonk" };
            //Check each value to make sure it is what is expected
            for (int i = 0; i < 10; i++)
            {
                returnedStrings[i].Should().Be(expectedStrings[i]);
            }
        }

    }
}
