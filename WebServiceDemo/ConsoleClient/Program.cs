using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.CalcService;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // create client-side "stub" object to use to call service methods
            CalcServiceClient calc = new CalcServiceClient();

            // set up data
            double n1 = 20.0, n2 = 5.0;
            double result;

            // test service
            //Console.WriteLine("TESTING CALCULATOR SERVICE");

            result = calc.Add(n1, n2);
            Console.WriteLine("Add {0} and {1}: Result is {2}", n1, n2, result);

            result = calc.Subtract(n1, n2);
            Console.WriteLine("Subtract {0} from {1}: Result is {2}", n2, n1, result);

            result = calc.Multiply(n1, n2);
            Console.WriteLine("Multiply {0} and {1}: Result is {2}", n1, n2, result);

            result = calc.Divide(n1, n2);
            Console.WriteLine("Divide {0} by {1}: Result is {2}", n1, n2, result);

            Console.ReadLine();
        }
    }
}
