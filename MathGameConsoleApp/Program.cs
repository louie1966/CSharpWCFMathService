using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGameConsoleApp.ServiceReferenceWcfMath;

namespace MathGameConsoleApp
{
    class Program
    {
        MathServiceClient srvClient = new MathServiceClient();

        static void Main(string[] args)
        {
            MathServiceClient srvClient = new MathServiceClient();

            int number1 = 10;
            int number2 = 2;

            Console.WriteLine("Hank sold {0} marbles for $ {1} each and earned $ {2} in total\n",
                number1.ToString(),
                number2.ToString(),
                srvClient.Multiply(number1, number2).ToString());

            Console.WriteLine("Suzy splitted her {0} sweets in {1}, to share with her friend.\nNow they have {2} sweets each\n",
                number1.ToString(),
                number2.ToString(),
                srvClient.Devide(number1, number2).ToString());

            Console.WriteLine("John had {0} stanps. His grandpa gave him {1} more. Now he has {2} stamps\n",
                number1.ToString(),
                number2.ToString(),
                srvClient.Add(number1, number2).ToString());

            Console.WriteLine("Sam owned {0} rabbits and {1} rabbits died last week.\nNow he owns {2} rabbits.",
                number1.ToString(),
                number2.ToString(),
                srvClient.Subtract(number1, number2).ToString());
        }
    }
}
