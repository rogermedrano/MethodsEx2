using System;

namespace MethodsEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();

            Spaces();
            
            Product();

            Divide();

        }

        public static void Add()
        {
            Console.WriteLine("Let's do some math.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Enter your first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;

            Console.WriteLine($"The sum of your two numbers is {sum}");
        }

        public static void Product()
        {
            Console.WriteLine("Now let's do some multiplication.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Enter your first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int num2 = int.Parse(Console.ReadLine());
            int product = num1 * num2;

            Console.WriteLine($"The product of your two numbers is {product}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            

        }

        public static void Divide()
        {
            Console.WriteLine("Now let's do some DIVISION.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Enter your first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int num2 = int.Parse(Console.ReadLine());
            int difference = num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine($"The difference of your two numbers is {difference} with a remainder of {remainder}");

        }

        public static void Spaces()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }


    }
}
