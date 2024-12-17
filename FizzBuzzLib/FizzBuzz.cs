using System.Collections;
using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange, IFlexiFizzBuzz
    {
        //Defining the default Dictionary
        public Dictionary<int, string> ReplacementPairs { get; }

        //Construcor to set default dictionary
        public FizzBuzz()
        {
            ReplacementPairs =  new Dictionary<int, string>() { { 3, "Fizz" }, { 5, "Buzz" } };
        }

        //Overwritten construcor to overwrite dictionary
        public FizzBuzz( Dictionary<int, string> Dict)
        {
            ReplacementPairs = Dict;
        }

        //This function recieves an integer and parses it into a string, unless it satistfies specific conditions
        public string FizzBuzzifyAnInt(int num)
        {
            //The value to be returned at the end
            string returnValue = "";
            //Loop through each pair in the dictionary
            foreach (var pair in ReplacementPairs)
            {
                //If the num is a multiple of key append the value on the end of the list
                if (num % pair.Key  == 0)
                {
                    returnValue+= pair.Value.ToString();
                }
            }
            //If it was a multiple of nothing return the number as a string
            if (returnValue == "")
            {
                returnValue=num.ToString();
            }
            return returnValue;
        }

        //return an IEnumerable of strings starting from start to end, that have been "FizzBuzzed" AKA call the FizzBuzzifyAnInt function on
        //each integer between start and end inclusively then return the IEnumerable of strings
        public IEnumerable<string> FizzBuzzValuesForRange(int start, int end)
        {
            //the list of strings that will be returned
            List<string> strings = new List<string>() {};
            //if the starting index is greater than the ending index return empty list
            if (start > end)
            {
                return strings;
            }
            //Loop through start to end inclusively
            for (int i = start; i <= end; i++)
            {
                string buzzed = FizzBuzzifyAnInt(i);
                strings.Add(buzzed);
            }
            return strings;
        }


    }

}
