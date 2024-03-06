using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public delegate void PrintDelegate(string a); // 1st delegate declaration

    internal class Program
    {
        static void Main(string[] args)
        {
            //printa("vishal"); // method call

            //printdelegate pd = new printdelegate(printa); // 2nd delegate instance
            //printdelegate pd = printa;

            //pd("mahesh"); // 3rd delegate call / invoke

            //printdelegate pd1 = printa;
            //printdelegate pd2 = printb;
            //printdelegate pd3 = printc;

            //printdelegate pd = pd1 + pd2 + pd3 - pd2;

            //pd("vishal");

            PrintDelegate pd = PrintA;
            pd += PrintB;
            pd += PrintC;
            pd -= PrintA; // de register

            pd("Aniket");

            Console.ReadLine();
        }

        static void PrintA(string name)
        {
            Console.WriteLine($"PrintA() : Hello, {name}");
        }
        static void PrintB(string name)
        {
            Console.WriteLine($"PrintB() : Welcome, {name}");
        }
        static void PrintC(string name)
        {
            Console.WriteLine($"PrintC() : Good Morning, {name}");
        }

        static string GetName()
        {
            return "Aniket";
        }
    }
}
