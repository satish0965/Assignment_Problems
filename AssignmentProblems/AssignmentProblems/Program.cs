using AssignmentProblems;
using System;

namespace AssignmentProblems

{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 for Fibonacci Series Problem");
            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.Fibonaaci();
                    break;

            }
        }
    }
}