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
            //Running FizzBuzzifyAnInt in console for manual testing
            var fizzBuzzer = new FizzBuzz();
            IEnumerable<string> rangeStrings = fizzBuzzer.FizzBuzzValuesForRange(4, 6);
            foreach (string i in rangeStrings)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
