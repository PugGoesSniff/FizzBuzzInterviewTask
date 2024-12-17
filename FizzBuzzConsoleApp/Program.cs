namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //Running FizzBuzzValuesForRange in console to print the "buzzed" values from 1 to 100
            var fizzBuzzer = new FizzBuzz();
            IEnumerable<string> rangeStrings = fizzBuzzer.FizzBuzzValuesForRange(1, 100);
            //Write each string to the console
            foreach (string i in rangeStrings)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
