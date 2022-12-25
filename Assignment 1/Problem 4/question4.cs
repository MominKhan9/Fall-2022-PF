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

 Console.Write("Enter age: ");
 int age = int.Parse(Console.ReadLine());
 Console.Write("Enter gender (M/F): ");
 char gender = char.Parse(Console.ReadLine());
 Console.Write("Enter distance: ");
 int distance = int.Parse(Console.ReadLine()); 
 if (age < 0 || distance < 0)
 {
 Console.WriteLine("Invalid input: age and distance must be nonnegative.");
 return;
 } 
 int basicFare;
 if (age < 18)
 {
 basicFare = 5;
 }
 else
 {
 basicFare = 10;
 } 
 int additionalFare = 0;
 if (distance > 5)
 {
 additionalFare = (distance - 5) * (age < 18 ? 3 : 5);
 }
 int totalFare = basicFare + additionalFare;
 Console.WriteLine("Total fare is : PKR:" + totalFare);
 Console.ReadKey();
 }
 }
}
