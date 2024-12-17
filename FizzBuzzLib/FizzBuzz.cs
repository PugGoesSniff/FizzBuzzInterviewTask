using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz
    {

        //This function recieves an integer and parses it into a string, unless it satistfies specific conditions
        public string FizzBuzzifyAnInt(int num)
        {
            //if multiple of 15 return FizzBuzz check 15 first otherwise it will never be met
            if (num % 15 == 0)
            {
                return "FizzBuzz";
            }
            //if multiple of 5 return Buzz
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            //if multiple of 3 return Fizz
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            //else return the interger as a string
            return num.ToString();
        }

        //return a list of strings starting from start to end, that have been "FizzBuzzed" AKA call the FizzBuzzifyAnInt function on
        //each integer between start and end inclusively then return the list of strings
        public List<string> IFizzBuzzRange(int start, int end)
        {
            //the list of strings that will be returned
            List<string> strings = new List<string> {};
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
