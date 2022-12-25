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

 Console.Write("Enter no of rows: ");
 int r = Convert.ToInt32(Console.ReadLine());
 for (int i = 1; i <= r; i++)
 {
 for (int j = 1; j <= i; j++)
 {
 Console.Write("*");
 }
 Console.WriteLine();
 }
 Console.ReadKey();
 }
 }
}