using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ECUtbildning.Labb2_4ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HobbyContractClient();
            Console.WriteLine("**My hobby is ocnverting lower case sentences to upper case**");
            Console.WriteLine("Please enter a sentence I can convert to uppercase!");
            var lowCaseString = Console.ReadLine();
            var result = client.CapitalizeLetters(lowCaseString);
            Console.WriteLine("Aaaa good, good, the result is the following..");
            Console.WriteLine($" -> {result}");
            Console.ReadLine();

        }
    }
}
