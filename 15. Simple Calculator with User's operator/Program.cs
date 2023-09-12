using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Simple_Calculator_with_User_s_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call for a method
            Calculator();

            //freeze the console
            Console.ReadLine();
        }
        static void Calculator()
        {
            Console.WriteLine("Enter first number");
            double x  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose your operator");
            string op = Console.ReadLine();
            Console.WriteLine("Enter second number");
            double y = Convert.ToDouble(Console.ReadLine());
            double Answer;
            if (op == "+")
            {
                Console.WriteLine(" The sum is ");
                Console.WriteLine(Answer = x + y);
            }
            else if (op == "-")
            {
                Console.WriteLine(" The difference is ");
                Console.WriteLine(Answer = x - y);
            }
            else if(op == "*")
            {
                Console.WriteLine(" The product is ");
                Console.WriteLine(Answer = x * y);
            }
            else if (op == "/")
            {
                Console.WriteLine(" The quotient is ");
                Console.WriteLine(Answer = x / y);
            }
            else
            {
                Console.WriteLine(" Not an operator");
            }
        }
    }
}
