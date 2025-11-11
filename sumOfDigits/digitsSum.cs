using System;

namespace sumOfDigits
{
    class digitsSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any integer number");
            long number = long.Parse(Console.ReadLine());
            Console.Write("Sum of digits of the {0} ", number);

            long sum = 0;
            do
            {
                sum += number % 10;
                number /= 10;

            } while (number != 0);

            if (sum < 0)
                sum = -sum;

            Console.WriteLine("is {0}", sum);
        }
    }
}
