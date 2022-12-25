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
 Console.WriteLine("Enter speed in miles per hour: ");
 double speedInMilesPerHour = Convert.ToDouble(Console.ReadLine());
 double speedInKilometersPerSecond = (speedInMilesPerHour * 1.609) / 
3600;
 Console.WriteLine(" speed in km/s is :"+speedInKilometersPerSecond 
);
 }
 }
 }