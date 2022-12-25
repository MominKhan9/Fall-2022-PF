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

 
 DateTime currentDate = DateTime.Now;
 
 Console.WriteLine("Enter your date of birth (dd/mm/yyyy): ");
 string dobString = Console.ReadLine();
 
 if (DateTime.TryParse(dobString, out DateTime dob))
 {
 
 if (dob > new DateTime(1582, 10, 4) && dob < currentDate)
 {
 
int ageInYears = currentDate.Year - dob.Year;
 if (currentDate.Month < dob.Month || (currentDate.Month == 
dob.Month && currentDate.Day < dob.Day))
 {
 ageInYears--;
 }
 
 int ageInMonths = ageInYears * 12 + currentDate.Month -
dob.Month;
 if (currentDate.Day < dob.Day)
{
 ageInMonths--;
 }
 
 TimeSpan ageInDays = currentDate - dob;
 
 Console.WriteLine($"Your age is {ageInYears} years, 
{ageInMonths} months, and {ageInDays.Days} days.");
 }
 else
 {
 Console.WriteLine("Invalid date of birth. Please enter a date 
after October 4, 1582 and before the current date.");
 }
 }
 else
 {
 Console.WriteLine("Invalid date of birth. Please enter a valid date 
in the format dd/mm/yyyy.");
 }
Console.ReadKey();
 }
 }
 }
