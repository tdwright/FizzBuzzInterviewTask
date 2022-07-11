namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzz();
            string value = fizzBuzzer.DemoMethod();
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
