using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ECUtbildning.Labb2_2AgeClientWinForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthdate (xx-xx-xx)");
            string age = Console.ReadLine();

            var dateAge = new DateTime(1977, 02, 07);

            AgeContractClient client = new AgeContractClient();
            var result = client.GetYourAge(dateAge);
            Console.WriteLine($"Du är {result.ToString()} år gammal din gamle gnu!");
            Console.ReadLine();
        }
    }
}
