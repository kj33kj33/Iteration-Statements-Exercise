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

        //public static void UpByThree()
        //{
        //    for (int i = 3; i < 1000; i += 3)
        //        Console.WriteLine(i);
        //}

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

        //public static bool TwoNumsSame(int num1, int num2)
        //{
        //    if(num1 == num2)
        //    {
        //        Console.WriteLine($"{num1} and {num2} are the same");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num1} and {num2} are not the same");
        //        return false;
        //    }
        //}

        public static void EvenCheck()
        {
            Console.WriteLine("Hi, please input a number to check if it is even or odd:");
            int i = int.Parse(Console.ReadLine());
            var isEven = (i % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(isEven);
        }

        //public static void EvenOrOdd(int num)
        //{
        //    if(num % 2 == 0)
        //    {
        //        Console.WriteLine($"{num} is even");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num} is odd");
        //    }
        //}
        public static void PositiveOrNegative()
        {
            Console.WriteLine("Please enter a number: ");
            var i = int.Parse(Console.ReadLine());
            var isPositive = (i > 0) ? "Number is Positive" : "Number is Negative";
            Console.WriteLine(isPositive);
        }

        //public static bool IsPositive(int num)
        //{
        //    if(num > 0)
        //    {
        //        Console.WriteLine($"{num} is positive");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num} is not positive");
        //        return false;
        //    }
        //}

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

        //public static bool CanVote()
        //{
        //    Console.WriteLine("Please enter your age: ");
        //    var canParse = int.TryParse(Console.ReadLine(), out int userAge);

        //    while (canParse == false)
        //    {
        //        Console.WriteLine("Please enter a valid age");
        //        canParse = int.TryParse(Console.ReadLine(), out userAge);
        //    }

        //    if(userAge >= 18)
        //    {
        //        Console.WriteLine($" Congrats! {userAge} is old enough to vote!");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Sorry, {userAge} is not old enough to vote.');
        //        return true;
        //    }
        //}

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

        //public static bool IsInTenRange(int num)
        //{
        //    if(num <= 10 && num >= -10)
        //    {
        //        Console.WriteLine($"{num} is in the ten range");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num} is not in the ten range");
        //        return false;
        //    }
        //}

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

        //public static void MultiplyThru12(int num)
        //{
        //    for(int i = 1; i <= 12; i++)
        //    {
        //        Console.WriteLine($"{i} x {num} = {i * num}");
        //    }
        //}

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
