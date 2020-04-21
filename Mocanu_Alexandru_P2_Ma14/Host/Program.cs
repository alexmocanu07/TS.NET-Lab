using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using ObjectWCF;

namespace HostWCF
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(DatabaseWCF),
            new Uri("http://localhost:8000/MyPhotos"));
            Console.WriteLine("Endpoint-urile serverului sunt:");
            foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
                Console.WriteLine("A (address): {0} \nB (binding): {1}\nC(Contract): {2}\n", endpoint.Address, endpoint.Binding.Name, endpoint.Contract.Name);
            host.Open();
            Console.WriteLine("Server pornit");
            Console.WriteLine("Apasati orice tasta pentru a inchide serverul.");
            Console.ReadKey();
            Console.WriteLine("\nServerul se inchide...");
            host.Close();

        }
    }
}
