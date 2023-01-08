using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int result;
                Console.WriteLine("Enter first Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Symbols(/,*,-,+)");
                string symbols = Console.ReadLine();

                switch (symbols)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Addition :" + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Substraction :" + result);
                        break;

                    case "*":
                        result = num1 + num2;
                        Console.WriteLine("Multiply :" + result);
                        break;

                    case "/":
                        result = num1 + num2;
                        Console.WriteLine("Divide :" + result);
                        break;

                    default:
                        Console.WriteLine("Enter wrong Input");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("for continue press y for Yes or press n for No ");
                value = Console.ReadLine();
            }
            while (value=="y"||value=="Y");
           
           
        }

    }
}
