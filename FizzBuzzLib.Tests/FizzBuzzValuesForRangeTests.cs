namespace FizzBuzzLib.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestPlatform.Utilities;
    using Xunit;

    public class FizzBuzzValuesForRangeTests
    {

        //Declaring all the data that I want to test
        public static IEnumerable<object[]> testData => new List<object[]>
        {
            new object[] { 4, 6,  new List<string> { "4", "Buzz", "Fizz" }},
            new object[] { -18, -15, new List<string> {"Fizz", "-17", "-16", "FizzBuzz" } },
            new object[] {-15, -18, new List<string> { } }
        };

        //Testing FizzBuzzValuesForRange_AllTests with the test cases defined in testData
        [Theory]
        [MemberData(nameof(testData))]
        public void FizzBuzzValuesForRange_AllTests(int start, int end, List<string> expectedStrings)
        {
            var fizzBuzzer = new FizzBuzz();
            IEnumerable<string> returnValue = fizzBuzzer.FizzBuzzValuesForRange(start, end);
            //Make sure both lists have equal lengths
            Assert.Equal(returnValue.Count(), expectedStrings.Count());
            //Check each to make sure each index match
            var index = 0;
            foreach (string i in returnValue)
            {
                i.Should().Be(expectedStrings[index]);
                index++;
            }
        }
    }
}
