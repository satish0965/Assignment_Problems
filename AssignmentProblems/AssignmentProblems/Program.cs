using AssignmentProblems;
using System;

namespace AssignmentProblems

{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("3 for Reverse Number Problem");
            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 3:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.Reverse();
                    break;

            }
        }
    }
}