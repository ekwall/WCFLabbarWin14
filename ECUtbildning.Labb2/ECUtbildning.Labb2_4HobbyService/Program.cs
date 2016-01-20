using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using ECUtbildning.Labb2_4HobbyContract;

namespace ECUtbildning.Labb2_4HobbyService
{
    public class Program
    {
        static void Main(string[] args)
        {

            Uri baseAddress = new Uri("http://localhost:8080/ECUtbildning.Labb2_4HobbyService");

            using (ServiceHost host = new ServiceHost(typeof(HobbyService), baseAddress))
            {

                try
                {
                    // ABC
                    host.AddServiceEndpoint(typeof(IHobby),
                                                        new WSHttpBinding(),
                                                        "HobbyService");

                // lägga till metadata behavior
                ServiceMetadataBehavior smBehavior = new ServiceMetadataBehavior();
                smBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smBehavior);

                
                    Console.WriteLine("Opens the line up");
                    host.Open();
                    Console.WriteLine("Line is open");
                    Console.WriteLine("Shut down with enter");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }

            }

                
        }
    }
}
