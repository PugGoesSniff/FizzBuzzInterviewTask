namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            //Running FizzBuzzifyAnInt in console for manual testing
            var fizzBuzzer = new FizzBuzz();
            string value = fizzBuzzer.FizzBuzzifyAnInt(4);
            Console.WriteLine(value);


            //Running IFizzBuzzRange in console for manual testing
            List<string> rangeStrings = fizzBuzzer.IFizzBuzzRange(4,6);
            Console.WriteLine(rangeStrings[2]);
            Console.ReadKey();
        }
    }
}
