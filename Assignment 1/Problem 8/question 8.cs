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

 int sum = 0;
 int count = 0;
 int number; 
 do
 {
 Console.WriteLine("Enter an integer :");
 number = Convert.ToInt32(Console.ReadLine());
 if (number != 0)
 {
 sum += number;
count++;
 }
 } while (number != 0);
 double mean = (double)sum / count;
 Console.WriteLine("The mean of the numbers is: " + mean);
 Console.ReadKey();
 }
 }
