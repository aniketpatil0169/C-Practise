using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10;
            Console.WriteLine(i);

            i = 20;
            Console.WriteLine(i);

            int a = i + j;
            Console.WriteLine(a); 

            int s = i - j;
            Console.WriteLine(s); 

            int m = i * j;
            Console.WriteLine(m); 

            int d = i / j;
            Console.WriteLine(d); 

            int mo = 5 % 2;
            Console.WriteLine(mo); 
            i++;
            Console.WriteLine(i); 

            Console.WriteLine(++i); 
            Console.WriteLine(i); 


            // compound assignment

            
            i -= 7;
            Console.WriteLine(i); 

            i *= 3;
            Console.WriteLine(i); 

            i /= 5;
            Console.WriteLine(i); 

            bool result = i == j;
            Console.WriteLine(result); 

            result = i != j;
            Console.WriteLine(result); 

            result = i < j;
            Console.WriteLine(result); 

            i++;
            result = i >= j;
            Console.WriteLine(result); 

            int k = 20;
            result = i >= j && j > k;
            Console.WriteLine(result); 

            result = i >= j || j > k;
            Console.WriteLine(result); 


            Console.ReadLine(); 
        }
    }
}
