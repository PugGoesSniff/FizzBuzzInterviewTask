namespace FizzBuzzLib.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestPlatform.Utilities;
    using Xunit;

    public class FizzBuzzifyAnIntWithDictionaryTests
    {
        //The three test cases that were requested in the readme
        public static IEnumerable<object[]> testData => new List<object[]>
        {
            new object[] { null,new List<string>() {"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz" } },
            new object[] { new Dictionary<int, string>() { { 2, "Even" } }, new List<string>() { "1", "Even", "3", "Even", "5", "Even", "7", "Even", "9", "Even" } },
            new object[] { new Dictionary<int, string>() { { 2, "Quack" }, { 5, "Honk" } }, new List<string>() { "1", "Quack", "3", "Quack", "Honk", "Quack", "7", "Quack", "9", "QuackHonk" } },
        };

        //A series of tests that will check if FizzBuzzifyAnInt returns what is expected when given new dictionaries
        [Theory]
        [MemberData(nameof(testData))]
        public void FizzBuzzifyAnInt_AllTestsWithDictionary(Dictionary<int, string> Dict, List<string> expectedStrings)
        {
            var fizzBuzzer= new FizzBuzz();
            //if the deafault dictionary needs to be overwritten, overwrite it
            if (Dict != null)
            {
                fizzBuzzer = new FizzBuzz(Dict);
            }
            //list of strings that need to be compared with expected
            List<string> returnedStrings = new List<string>() { };
            //Test 1-10 inclusively
            for (int i = 1; i <= 10; i++) //If we want to make it where it can test different ranges 1 and 10 can become paramaters that get passed in.
            {
                returnedStrings.Add(fizzBuzzer.FizzBuzzifyAnInt(i));
            }
            //Check each value to make sure it is what is expected
            for (int i = 0; i < 10; i++)
            {
                returnedStrings[i].Should().Be(expectedStrings[i]);
            }
        }
    }
}
