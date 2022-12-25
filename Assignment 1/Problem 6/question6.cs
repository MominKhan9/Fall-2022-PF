using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
namespace sir_farooq_assigment_2
{
 internal class Program
 {
 static void Main(string[] args)
 {
///Q6 SUM DIGIT
 Console.WriteLine("Enter a positive integer:");
 int num = int.Parse(Console.ReadLine());
 int sum = 0;
 while (num > 0)
 {
 sum += num % 10;
 num /= 10;
 }
 Console.WriteLine("Sum of digits: " + sum);
Console.ReadKey();
}
 }
}
