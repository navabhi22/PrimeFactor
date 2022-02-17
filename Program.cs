using System;

namespace PrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N ");
            int N = Convert.ToInt32(Console.ReadLine());

            //PrimeNumber.PrimeNum(N);

            PrimeFactors.PrimeFactor(N);
        }
    }
}