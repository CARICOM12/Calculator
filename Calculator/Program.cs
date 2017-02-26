using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorApp c = new CalculatorApp();
            do
            {
                Console.WriteLine("Please enter an expression: ");
                string expression = Console.ReadLine();
                try
                {
                    int result = c.Compute(expression);
                    Console.WriteLine("The result is: {0}", result);
                }
                catch
                {
                    Console.WriteLine("Error occured!");
                }
                Console.WriteLine("Press q to exit or any other key to continue");
            }
            while (Console.ReadKey().KeyChar != 'q') ;
        }
    }
}
