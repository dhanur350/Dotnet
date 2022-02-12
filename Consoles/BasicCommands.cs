using System;
namespace Consoles
{
    class Program
    {
        public int adding()
        {
            int a, b, c;
            Console.Write("Enter two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Addition of two numbers are :" + c);
            return 0;
        }
        public void arrays()
        {
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] sum = new int[3, 3];
            int i, j;
            Console.WriteLine(" Enter elements of 1st matrix ");
            for (i = 0; i < 3; ++i)
                for (j = 0; j < 3; ++j)
                    a[i, j] = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter elements of 1st matrix ");
            for (i = 0; i < 3; ++i)
                for (j = 0; j < 3; ++j)
                    b[i, j] = int.Parse(Console.ReadLine());
            // adding two matrices
            for (i = 0; i < 3; ++i)
                for (j = 0; j < 3; ++j)
                    sum[i, j] = a[i, j] + b[i, j];
            //Printing the Result
            Console.WriteLine("The sum of two matrix are :");
            for (i = 0; i < 3; ++i)
                for (j = 0; j < 3; ++j)
                {
                    Console.Write(" "+sum[i,j]);
                    if (j == 3 - 1)
                        Console.Write("\n");
                }
        }
        public void strings()
        {
            //Declaring a variable using strings...
            string friend = "Rahul";
            Console.WriteLine(friend);
            //using declared variable in printing statement...
            Console.WriteLine($"Hello {friend}");
            //now declaring 2 variables and using them in one statements
            string friend1 = "Rakesh";
            string friend2 = "Kirti";
            //Syntax of using a variable value in the console.writeline....
            Console.WriteLine($"My friends are {friend1} and {friend2}");
            //Now to check the length of a string value stored....
            Console.WriteLine($"The length of {friend1} is {friend1.Length}");
            Console.WriteLine($"The length of {friend2} is {friend2.Length}");
            Console.WriteLine("Hello World!");
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine(" Collection of 1 to 10 Programs : \n Choose any one to run :");
            Console.WriteLine(" 1. Strings \n 2. Addition \n 3. Arrays ");
            int b = int.Parse(Console.ReadLine());
            switch (b)
            {
                case 1:
                a.strings(); break;
                case 2:
                a.adding(); break;
                case 3:
                a.arrays(); break;
                default:
                Console.WriteLine("Wrong option"); break;
            }
        }
    }
}
