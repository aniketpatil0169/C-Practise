using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 12;

            //if (i == 10)
            //{
            //    console.writeline($"{i} : ten");
            //    // console.writeline("even");                
            //}
            //else
            //{
            //    console.writeline($"{i} : not ten");
            //}

            // console.writeline($"{i} : not ten");

            // ternary operator
            // (condition) ? statement1(true) : statement2(false);

            //i = 10;
            //string result = (i == 10) ? "ten" : "not ten";
            //console.writeline($"{i} : {result}");

            // if-else if-else ladder

            //i = 10;
            //if (i == 10)
            //{
            //    console.writeline($"{i} : ten");
            //}
            //else if (i == 20)
            //{
            //    console.writeline($"{i} : twenty");
            //}
            //else if (i == 30)
            //{
            //    console.writeline($"{i} : thirty");
            //}
            //else
            //{
            //    console.writeline($"{i} : not 10 20 or 30");
            //}

            // switch
            //i = 100;
            //switch (i)
            //{
            //    case 10:
            //        console.writeline($"{i} : ten");
            //        break;
            //    case 20:
            //        console.writeline($"{i} : twenty");
            //        break;
            //    case 30:
            //        console.writeline($"{i} : thirty");
            //        break;
            //    default:
            //        console.writeline($"{i} : not 10 20 or 30");
            //        break;
            //}

            int a = 10, b = 11;
            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else if (b > a)
            {
                Console.WriteLine($"{b} is greater than {a}");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are equal");
            }

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);

            Console.ReadLine();
        }
    }
}
