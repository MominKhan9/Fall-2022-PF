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
 Console.Write("Enter a positive integer: ");
 int n = int.Parse(Console.ReadLine());
 Console.WriteLine($"The {n}th Fibonacci number is {Fibonacci(n)}.");
 }
 static int Fibonacci(int n)
 {
 if (n == 0) return 0;
 if (n == 1) return 1;
 return Fibonacci(n - 1) + Fibonacci(n - 2);
 }
 }
}