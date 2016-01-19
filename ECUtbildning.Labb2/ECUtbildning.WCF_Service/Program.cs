using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ECUtbildning.SelfService;
using System.ServiceModel.Description;

namespace ECUtbildning.WCF_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/ECUtbildning.WCF_Service");

            // ABC
            ServiceHost host = new ServiceHost(typeof(CalculateBMI), baseAddress);

            try
            {
                host.AddServiceEndpoint(typeof(ICalculateBMI), new WSHttpBinding(),
                    "CalculateBMI");

                // Metadata för att hitta tjänsten via WSDL-document
                ServiceMetadataBehavior smBehavior = new ServiceMetadataBehavior();
                smBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smBehavior);

                // Starta
                host.Open();
                Console.WriteLine("Tjänsten är öppen!");

            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                //Exit
                Console.WriteLine("Stäng tjänsten med Enter");
                Console.ReadLine();
            }

            
        }
    }
}
