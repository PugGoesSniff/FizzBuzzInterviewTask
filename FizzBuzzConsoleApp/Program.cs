namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzz();
            string value = fizzBuzzer.FizzBuzzifyAnInt(4);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
