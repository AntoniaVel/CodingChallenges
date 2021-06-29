using System;

namespace PostcodeParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 2: Postcode parser
            var problemTwo = new ProblemTwo
            {
                PostCode = "CT21 4LR"
            };
            Console.WriteLine(problemTwo.PostCodeParser());
        }
    }
}