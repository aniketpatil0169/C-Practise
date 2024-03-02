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
            string name = "aniket";
            Console.WriteLine(name);

            name = null; 
            Console.WriteLine(name);


            int? age = null;
            bool? isDelivered = null;
            DateTime? dob = null; 

            Nullable<int> marks = null; 

            int? a = null;
            
            int b = a ?? 0;
            Console.WriteLine($"a : {a} b : {b}");

            
            string email = null;
            string emailInUnpper = email?.ToUpper();
            Console.WriteLine($"email: {email}\nemail in upper : {emailInUnpper}");
            


            Console.ReadLine();
        }
    }
}
