sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace assignment_2
{
 internal class Program
 {
 static void Main(string[] args) 
 {

 Console.WriteLine(CalculatePersistence());
 int CalculatePersistence()
 {
 Console.WriteLine("Enter a number: ");
 int number = int.Parse(Console.ReadLine());
 int persistence = 0;
 while (number > 9)
 {
 int result = 1;
foreach (char c in number.ToString())
 {
 result *= int.Parse(c.ToString());
 }
number = result;
persistence++;
 }
 return persistence;
 }
 }
 }
}
