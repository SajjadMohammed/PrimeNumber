using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var prime = new Prime();
            var result = prime.IsPrime(5) ? "Prime" : "Not Prime";
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}