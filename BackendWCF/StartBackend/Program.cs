using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using BackendWCF;
namespace StartBackend
{
    class Program
    {
        //NOTE: DETTE PROGRAM SKAL KØRES SOM ADMINISTRATOR
        static void Main(string[] args)
        {
            // Step 1 Create a URI to serve as the base address.
            Uri baseAddress = new Uri("http://localhost:8584/DTU");

            // Step 2 Create a ServiceHost instance
            ServiceHost selfHost = new ServiceHost(typeof(Service1), baseAddress);

            try
            {
                // Step 3 Add a service endpoint.
                selfHost.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "Service1");

                // Step 4 Enable metadata exchange.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Step 5 Start the service.
                selfHost.Open();
                Console.WriteLine("-- WCF Backend til event management kører nu!! --");
                Console.WriteLine("62413 - Advanceret objektorienteteret programmering med C# og .NET");
                Console.WriteLine("Sofie, Simon og Christoffer - F18");
                Console.WriteLine("");
                Console.WriteLine("Web service er nu opstartet på url: " + baseAddress);
                Console.WriteLine("");
                Console.WriteLine("Tryk <ENTER> for at terminere web service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}