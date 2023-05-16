using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace IterationStatements
{
    public class Program
    {
        public static void Print1000Nums()
        {
            for (int i = 1000; i >= -1000; i--)
                Console.WriteLine(i);
        }

        public static void Print3s()
        {
            for (int i = 3; i < 1000; i++)
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
        }

        public static void IsEqualTo()
        {
            Console.WriteLine("Enter first number:");
            var firstNum = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            var secondNum = Console.ReadLine();

            var isEqual = (firstNum != secondNum) ? $"{firstNum} does not equal {secondNum}" : $"{firstNum} = {secondNum}";

            if (firstNum != secondNum)
            {
                Console.WriteLine($"{firstNum} does not equal {secondNum}");
            }
            else
                Console.WriteLine($"{firstNum} = {secondNum}");
        }

        public static void EvenCheck()
        {
            Console.WriteLine("Hi, please input a number to check if it is even or odd:");
            int i = int.Parse(Console.ReadLine());
            var isEven = (i % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(isEven);
        }
        public static void PositiveOrNegative()
        {
            Console.WriteLine("Please enter a number: ");
            var i = int.Parse(Console.ReadLine());
            var isPositive = (i > 0) ? "Number is Positive" : "Number is Negative";
            Console.WriteLine(isPositive);
        }

        public static void OldEnoughToVote()
        {
            Console.WriteLine("Please enter your birthday beginning with the year:");
            var birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the month you were born:");
            var birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the day you were born:");
            var birthDay = int.Parse(Console.ReadLine());

            var votingYear = 2005;
            var votingMonth = 5;
            var votingDay = 16;

            if (birthYear < votingYear)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                if (birthMonth < votingMonth)
                {
                    Console.WriteLine("You can vote");
                }
                else
                {
                    if (birthDay <= votingDay)
                    {
                        Console.WriteLine("You can vote");
                    }
                    else
                    {
                        Console.WriteLine("You aren't old enough to vote");
                    }
                }
            }
        }

        public static void IntegerRangeCheck()
        {
            Console.WriteLine("Please input an integer:");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine($"{userInput} is in the range -10 to 10");
            }
            else
            {
                Console.WriteLine($"{userInput} is not in range");
            }
        }

        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter a whole number to generate a multiplication table from 1 to 12");
            var userInput = int.Parse(Console.ReadLine());
            for (int i = 1; i < 13; i++)
            {
                var answer = i * userInput;
                Console.WriteLine($"{userInput} * {i} = {answer}");
            }
        }

        static void Main(string[] args)
        {
            Print1000Nums();
            Print3s();
            IsEqualTo();
            EvenCheck();
            PositiveOrNegative();
            OldEnoughToVote();
            IntegerRangeCheck();
            MultiplicationTable();
        }
    }
}
