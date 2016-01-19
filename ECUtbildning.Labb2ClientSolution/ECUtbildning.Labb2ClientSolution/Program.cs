using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ECUtbildning.Labb2ClientSolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your length");
            int length = int.Parse(Console.ReadLine());

            CalculateBMIClient client = new CalculateBMIClient();
            double result = client.CalcBMI(weight, length);
            Console.WriteLine("the result is: " + result);
            Console.ReadLine();

        }
    }
}
