using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.ServiceReference1;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            client.CreateEvent("Testevent", "Test beskrivelse", "Imorgen kl 18", "Anker Egelundsvej 101E");
            String result = client.GetAllEventString();
            System.Console.Out.WriteLine("Hentet resultat fra backend: " + result);
            Console.ReadLine();
            client.Close();
        }
    }
}
