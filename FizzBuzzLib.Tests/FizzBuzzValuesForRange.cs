namespace FizzBuzzLib.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestPlatform.Utilities;
    using Xunit;

    public class IFizzBuzzRange
    {
        //Testing IFizzBuzzRange to see if the function returns what is expected when it recieves positive ranges
        [Fact]
        public void IFizzBuzzRange_WhenPassedPositiveRange()
        {
            var fizzBuzzer = new FizzBuzz();
            IEnumerable<string> returnValue = fizzBuzzer.FizzBuzzValuesForRange(4, 6); //Test 4,6 should return {"4","Buzz","Fizz"}
            List<string> expectedValue = new List<string> { "4", "Buzz", "Fizz" };
            //Make sure both lists have equal lengths
            if (returnValue.Count() == expectedValue.Count)
            {
                var index = 0;
                //Check each to make sure each index match
                foreach (string i in returnValue)
                {
                    i.Should().Be(expectedValue[index]);
                    index++;
                }
            }
            //If they don't return fail
            else
            {
                0.Should().Be(1);
            }
        }


        //Testing IFizzBuzzRange to see if the function returns what is expected when it recieves negative ranges
        [Fact]
        public void IFizzBuzzRange_WhenPassedNegativeRange()
        {
            var fizzBuzzer = new FizzBuzz();
            IEnumerable<string> returnValue = fizzBuzzer.FizzBuzzValuesForRange(-18, -15); //Test -18,-15, should return {"Fizz",-17,-16,"FizzBuzz"}
            List<string> expectedValue = new List<string> { "Fizz", "-17", "-16", "FizzBuzz" };
            //Make sure both lists have equal lengths
            if (returnValue.Count() == expectedValue.Count)
            {
                var index = 0;
                //Check each to make sure each index match
                foreach (string i in returnValue)
                {
                    i.Should().Be(expectedValue[index]);
                    index++;
                }
            }
            //If they don't return fail
            else
            {
                0.Should().Be(1);
            }
        }


        //Testing IFizzBuzzRange to see if the function returns what is expected when it recieves inverted ranges
        [Fact]
        public void IFizzBuzzRange_WhenPassedInvertedRange()
        {
            var fizzBuzzer = new FizzBuzz();
            IEnumerable<string> returnValue = fizzBuzzer.FizzBuzzValuesForRange(-15, -18); //Test -15,18, should return {}
            List<string> expectedValue = new List<string> { };
            //Make sure both lists have equal lengths
            if (returnValue.Count() == expectedValue.Count)
            {
                var index = 0;
                //Check each to make sure each index match
                foreach (string i in returnValue)
                {
                    i.Should().Be(expectedValue[index]);
                    index++;
                }
            }
            //If they don't return fail
            else
            {
                0.Should().Be(1);
            }
        }

    }
}
