using AssignmentProblems;
using System;

namespace AssignmentProblems

{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("5 for Factors Problem");
            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 5:
                    FactorsProb factors = new FactorsProb();
                    factors.Factors();
                    break;
            }
        }
    }
}