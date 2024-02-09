using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_Operation
{
    internal class Cal_Operation
    {
        static void Main(string[] args)
        {
            int number_1;
            int number_2;
            char operation;
            double answer;

            Console.Write("Please enter number_1 = ");
            number_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter number_2 = ");
            number_2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter operation (+, -, *, /) = ");
            operation = Convert.ToChar(Console.ReadLine());

            if (operation == '+')
            {
                answer = number_1 + number_2;
                Console.WriteLine("\n{0} + {1} = {2}", number_1, number_2, answer);

            }
            else if (operation == '-')
            {
                answer = number_1 - number_2;
                Console.WriteLine("\n{0} - {1} = {2}", number_1, number_2, answer);

            }
            else if (operation == '*')
            {
                answer = number_1 * number_2;
                Console.WriteLine("\n{0} * {1} = {2}", number_1, number_2, answer);

            }
            else if (operation == '/')
            {

                answer = (double)number_1 / (double)number_2;
                Console.WriteLine("\n{0} / {1} = {2:F3}", number_1, number_2, answer);
            }
            else
                Console.WriteLine("\nWrong operation!!");
        }
    }
}
