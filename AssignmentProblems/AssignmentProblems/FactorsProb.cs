using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProblems
{
    internal class FactorsProb
    {
        public void Factors()
        {
            Console.Write("\tEnter the number to be find factorization: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write("\t" + i);
                }
            }
        }
    }
}
