using System;

namespace sumOfDigits
{
    class digitsSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any integer number");
            string numberStr = Console.ReadLine();
            long number = long.Parse(numberStr);
            Console.Write("Sum of digits of {0} ", number);

            long sum = 0;
            do
            {
                sum += number % 10;
                number /= 10;

            } while (number != 0);

            if (sum < 0)
                sum = -sum;

            Console.WriteLine("is {0}", sum);

            sum = 0;
            for (int i = 0; i < numberStr.Length; i++)
            {
                sum += (long)numberStr[i] - 48;
            }

            Console.WriteLine("Sum of digits of {0} is {1}", numberStr, sum);
        }
    }
}
