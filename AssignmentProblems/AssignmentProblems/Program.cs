using AssignmentProblems;
using System;

namespace AssignmentProblems

{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("4 for Palindrom Number Problem");
            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 4:
                    PalindromeNumber palin = new PalindromeNumber();
                    palin.Palindrom();
                    break;
            }
        }
    }
}