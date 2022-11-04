using AssignmentProblems;
using System;

namespace AssignmentProblems

{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("6 for Factorial Number Problem");
            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 6:
                    FactorialNumber factorial = new FactorialNumber();
                    factorial.Factorial();
                    break;
            }
        }
    }
}