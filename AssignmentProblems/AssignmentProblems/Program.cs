using AssignmentProblems;
using System;

namespace AssignmentProblems

{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("2 for Prime Number Problem");
            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 2:
                    PrimeNumber prob = new PrimeNumber();
                    prob.PrimeNumbers();
                    break;

            }
        }
    }
}