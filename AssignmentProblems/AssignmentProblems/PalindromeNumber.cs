using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProblems
{
    internal class PalindromeNumber
    {
        public void Palindrom()
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter the number :");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Number is Palindrom ");
            else
                Console.WriteLine("Number is not Palindrom");
        }
    }
}
