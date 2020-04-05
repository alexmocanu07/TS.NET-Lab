using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace TestClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabaseClient client = new DatabaseClient();
            client.CreateFile(@"D:\aa.txt", "test");
            
            client.Close();
        }
    }
}
