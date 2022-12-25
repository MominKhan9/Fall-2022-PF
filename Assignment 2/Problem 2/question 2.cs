using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace sir_farooq_asigment
{
 internal class Program
 {
 static void Main(string[] args)
 {

 for (int i = 1; i <= 100000; i++)
 {
 int sum = 0;
 for (int j = 1; j < i; j++)
 {
 if (i % j == 0)
{
 sum += j;
 }
 }
 if (sum == i)
 {
 Console.WriteLine(i);
 }
 }
 }
 }
}
