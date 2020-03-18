using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            //TestPerson();
            //TestOneToMany();
            TestManyToMany();

            Console.ReadKey();
        }

        private static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                Person p = new Person() { FirstName = "Julie", LastName = "Andrew", MiddleName = "T", TelephonNumber = "123456789" };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }

        private static void TestOneToMany()
        {
            Console.WriteLine("One to Many Association");
            using (Model1Container context = new Model1Container())
            {
                Customer c = new Customer() { Name = "Customer 1", City = "Iasi" };
                Order o1 = new Order() { TotalValue = 200, Date = DateTime.Now, Customer = c };
                Order o2 = new Order() { TotalValue = 300, Date = DateTime.Now, Customer = c };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();

                var items = context.Customers;
                foreach(var x in items)
                {
                    Console.WriteLine("Customer: {0} {1} {2}", x.Id, x.Name, x.City);

                    foreach(var y in x.Orders)
                    {
                        Console.WriteLine("\t Orders: {0} {1}, {2}", y.Id, y.Date, y.TotalValue);
                    }
                }
            }
        }

        private static void TestManyToMany()
        {
            using(Model1Container context = new Model1Container())
            {
                Artist a1 = new Artist() { FirstName = "Jack", LastName = "Jackson" };
                Artist a2 = new Artist() { FirstName = "John", LastName = "Doe" };
                Artist a3 = new Artist() { FirstName = "Janet", LastName = "Jane" };

                Album b1 = new Album() { Name = "Album1", Artists = { a1, a2 } };
                Album b2 = new Album() { Name = "Album2", Artists = { a2, a3 } };

                context.Artists.Add(a1);
                context.Artists.Add(a2);
                context.Artists.Add(a3);
                context.Albums.Add(b1);
                context.Albums.Add(b2);
                context.SaveChanges();

                var items = context.Artists;

                foreach(var x in items)
                {
                    Console.WriteLine("Artist: {0}, {1}, {2} ", x.Id, x.FirstName, x.LastName);
                    foreach(var y in x.Albums)
                    {
                        Console.WriteLine("\tAlbum: {0}, {1}", y.Id, y.Name);
                    }
                }
            }
        }
    }
}
