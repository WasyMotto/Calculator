using System;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int result;
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an operator: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
                Console.Readline();
                Console.WriteLine("Do you want to continue? (yes/no)");
                value = Console.ReadLine();

            }
            while (value == "yes" || value == "Yes" || value == "y" || value == "Y");
        }
    }
}