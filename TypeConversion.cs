using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 20, j = 30;
            Console.WriteLine(i + j);

            Console.WriteLine(i - j);

            string a = i.ToString(); 
            string b = j.ToString();
            Console.WriteLine(a + b); 

            byte b1 = 10;
            short s1 = b1; 
            Console.WriteLine(s1); 

            float f1 = s1;
            Console.WriteLine(f1);

            
            int i1 = (int)f1;
            Console.WriteLine(i1);

            f1 = 25.55f;
            i1 = (int)f1;
            Console.WriteLine(i1);

            string s = "10000";
            

            i1 = Convert.ToInt32(s);
            Console.WriteLine(i1); 

            s = "true";
            bool bb = Convert.ToBoolean(s); 
            Console.WriteLine(bb);


            s = "1111";
            
            i1 = int.Parse(s);
            Console.WriteLine(i1);

            
            s = "1111";
            bb = int.TryParse(s, out i1);
            Console.WriteLine($"Status : {bb} Result : {i1}");

            s = "ABC";
            bb = int.TryParse(s, out i1);
            Console.WriteLine($"Status : {bb} Result : {i1}"); 

            decimal x = 10.52m;
            long l = (long)x; 
            Console.WriteLine(l); 

            Console.ReadLine();
        }
    }
}
