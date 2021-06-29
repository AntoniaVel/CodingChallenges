using System;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1: FizzBuzz
            var problemOne = new ProblemOne();
            problemOne.PrintNumbers();

            // Problem 2: Postcode parser
            var problemTwo = new ProblemTwo
            {
                PostCode = "CT21 4LR"
            };
            Console.WriteLine(problemTwo.PostCodeParser());
        }

    }
}