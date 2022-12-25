using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace sir_farooq_assigment_2
{
 internal class Program
 {
 static void Main(string[] args)
 {
 // Enter a positive integer
 Console.Write("Enter a positive integer: ");
 int number = int.Parse(Console.ReadLine());
 // Check if the number is less than or equal to 0
 if (number <= 0)
 {
 // If the number is less than or equal to 0, print an error 
message
 Console.WriteLine("Invalid input");
 }
 else
 {
 // If the number is greater than 0, check if it is even or odd
if (number % 2 == 0)
{
 // If the number is divisible by 2, it is even
Console.WriteLine(number + " is even");
 }
else
{
 // If the number is not divisible by 2, it is odd
 Console.WriteLine(number + " is odd");
 }
 }
}
 }
 }
