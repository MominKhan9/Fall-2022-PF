using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
namespace assignment_2
{
 internal class Program
 {
 static void Main(string[] args)
 {
 int n1=0,n2=1,n3,i,number;    
         Console.Write("Enter nth term you want: ");    
         number = int.Parse(Console.ReadLine());  
         Console.Write(n1+" "+n2+" ");     
         for(i=2;i<number;++i)   
         {    
          n3=n1+n2;    
          Console.Write(n3+" ");    
          n1=n2;    
          n2=n3; 
         }
 }
 }
}
