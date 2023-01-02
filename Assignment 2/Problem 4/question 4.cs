using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
namespace assignment_2
{
 internal class Program
 {
 static void Main(string[] args)
 {

 
 for (int i = 3; i <= 3000; i++)
 {
 if (IsPrime(i) && IsPrime(i + 2))
{
 Console.WriteLine($"{i} and {i + 2}");
 }
 }
 }
 static bool IsPrime(int number)
 {
 if (number < 2) return false;
 if (number == 2) return true;
 if (number % 2 == 0) return false;
 for (int i = 3; i <= Math.Sqrt(number); i += 2)
 {
 if (number % i == 0) return false;
 }
 return true;
 }
 }
 }
