using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace sir_farooq_asigment
{
    internal class Program
    {

        static void Main(string[] args)
        {
         Console.WriteLine("Enter a number to calculate its factorial:");
            int num = Convert.ToInt32(Console.ReadLine());
            int fac = num;

            for (int i = num -1; i >0; i--)
            {
               int sum =0;
                for (int j = 0; j < i; j++)
                {
                    sum=sum+fac;
                }
                fac = sum;
            }

            Console.WriteLine("The factorial of " + num + " is " + fac);
            Console.ReadKey();
        }
    }
}
