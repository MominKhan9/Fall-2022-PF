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

 Console.Write("Enter are you male or female: ");
 string gender = Console.ReadLine();
 Console.Write("Enter your age: ");
 int age = int.Parse(Console.ReadLine());
 if (gender == "male")
 {
 if (age >= 18)
 {
 Console.WriteLine("you are male adult");
 }
 else
 {
 Console.WriteLine("you are male minor");
 }
 }
 else if (gender == "female")
 {
 if (age >= 16)
 {
 Console.WriteLine("you are female adult");
 }
 else
 {
 Console.WriteLine("you are female minor");
 }
 }
 Console.ReadKey();
 }
 }
}
