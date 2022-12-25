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
 int num = int.Parse(Console.ReadLine());
 int factorial = 1;
 for (int i = 1; i <= num; i++)
 {
 factorial = factorial + (factorial * (i - 1));
 }
 Console.WriteLine("The factorial of " + num + " is " + factorial);
 }
 }
}