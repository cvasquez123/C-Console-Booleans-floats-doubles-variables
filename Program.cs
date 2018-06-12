using System;

namespace csTesting1
{
    class Program
    {
        private const double V = 22.3;

        static void Main(string[] args)
        { 
            string firstName = "carlos";
            string lastName = "vasquez";
            int age = 21;
            double rating = 10.0;
            bool feel = true;

            
            // Console is the class, writeline is the method
            Console.WriteLine("Hello My name is {0} and my last name is {1}, I am {2} years old. In a rating scale I'm a {3}, this is so {4} ", firstName,lastName,age,rating,feel);
            Console.ReadKey();

            string jokes = "Yo mama";
            Console.WriteLine("Hello young sir, Welcome to {0}", jokes);
            Console.ReadKey();

            Console.Write("Please give us your mamas name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.ReadKey();

            Console.WriteLine("Your mama {0}, is so ugly, she looking like a horse", name);
            Console.ReadKey();

            // Relational operators
            Console.WriteLine(5 < 90);
            Console.WriteLine("awsome" == "awsome");
            Console.WriteLine("Cars" == "Motorcycle");
            Console.WriteLine(10 > 5);
            Console.WriteLine("robot" != "human"); //this is true, been does not equal william

            




            
            

            

     


            
        }
    }
}
