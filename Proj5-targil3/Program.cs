using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj5_targil3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsWorking = true;
            while (IsWorking)
            {


                Console.WriteLine("Select the desired mathematical action:\n 1:Addition\n 2:Subtraction\n 3:Multiplication\n 4:Division\n 5:Exit\n");
                int x = int.Parse(Console.ReadLine());
                Console.Clear();
                if (x == 5)
                {
                    Console.WriteLine("Bye Bye");
                    return;
                }

                Console.WriteLine("Your Sum is :" + Menu(x));
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadLine();
                Console.Clear();

            }


        }
        static int Menu(int x)
        {
            Console.WriteLine("Enter 2 Numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;
            switch (x)
            {

                case 1:
                    sum = Addition(num1, num2);
                    break;
                case 2:
                    sum = Subtraction(num1, num2);
                    break;
                case 3:
                    sum = Multiplication(num1, num2);
                    break;
                case 4:
                    sum = Division(num1, num2);
                    break;

            }
            return sum;
        }
        static int Addition(int x, int y)
        {
            return x + y;
        }
        static int Subtraction(int x, int y)
        {
            return x - y;
        }
        static int Multiplication(int x, int y)
        {
            return x * y;
        }
        static int Division(int x, int y)
        {
            return x / y;
        }


    }
}
