using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace q_5_6
{
 internal class Program
 {
 static void Main(string[] args)
 {

 Console.Write("Enter 7 digit integer: ");
 int floor = Convert.ToInt32(Console.ReadLine());
 if (floor == 0110000)
 {
 Console.WriteLine("1 floor");
 }
 else if (floor == 1101101)
 {
 Console.WriteLine("2 floor");
 }
 else if (floor == 1111001)
 {
 Console.WriteLine("3 floor");
 }
 else if (floor == 0110011)
 {
 Console.WriteLine("4 floor");
 }
 else if (floor == 1011011)
 {
 Console.WriteLine("5 floor");
 }
 else if (floor == 1011111)
 {
 Console.WriteLine("6 floor");
 }
 else if (floor == 1110000)
 {
 Console.WriteLine("7 floor");
 }
 else if (floor == 1111111)
 {
 Console.WriteLine("8 floor");
 }
 else if (floor == 1111011)
 {
 Console.WriteLine("2 floor");
 }
 else
 {
 Console.WriteLine("invalid input");
 }
 Console.ReadKey()
}
 }
 }
