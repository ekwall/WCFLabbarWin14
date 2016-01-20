using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ECUtbildning.Labb2_3ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Birthdate (19xx,xx,xx)");
            var date = Console.ReadLine();
            
            var client = new ThousandDaysOldClient();
            var result = client.GetNextDateForThousandYearBirthday(date);

            Console.WriteLine($"Your next thousand day birthday is at {result.ToShortDateString().ToString()}");
            Console.ReadLine();

        }

       
    }
}
