﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudiiCaz
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEmployees();
        }
        static void TestSelfReferences()
        {
            using (ModelSelfReference context = new ModelSelfReference())
            {
                SelfReference ref1 = new SelfReference(){Name = "ref1"};

                SelfReference ref2 = new SelfReference(){Name = "ref2"};

                ref1.References.Add(ref2);
                context.SelfReferences.Add(ref1);
                context.SelfReferences.Add(ref2);
                int saved = context.SaveChanges();
                if(saved < 1)
                {
                    System.Console.WriteLine("Could not add references");
                    return;
                }

                foreach (var reference in context.SelfReferences)
                {
                    if (reference.References != null)
                    {
                        foreach (var reference2 in reference.References)
                        {
                            System.Console.WriteLine(reference2.Name);
                        }
                    }

                }
            }
        }

        static void TestProducts()
        {
            using (var context = new ModelProduct())
            {
                var product = new Product
                {
                    SKU = 147,
                    Description = "Expandable Hydration Pack",
                    Price = 19.97M,
                    ImageURL = "/pack147.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 178,
                    Description = "Rugged Ranger Duffel Bag",
                    Price = 39.97M,
                    ImageURL = "/pack178.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 186,
                    Description = "Range Field Pack",
                    Price = 98.97M,
                    ImageURL = "/noimage.jp"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 202,
                    Description = "Small Deployment Back Pack",
                    Price = 29.97M,
                    ImageURL = "/pack202.jpg"
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
            using (var context = new ModelProduct())
            {
                foreach (var p in context.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                    p.Price.ToString("C"), p.ImageURL);
                }
            }
        }

        static void TestPhotographs()
        {
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var context = new ModelPhotograph())
{
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage
                {
                    HighResolutionBits =
                fullBits
                };
                photo.PhotographFullImage = fullImage;
                context.Photographs.Add(photo);
                context.SaveChanges();
            }
            using (var context = new ModelPhotograph())
{
                foreach (var photo in context.Photographs)
                {
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes",
                    photo.Title, photo.ThumbnailBits.Length);
                    // explicitly load the "expensive" entity,
                    context.Entry(photo)
                    .Reference(p => p.PhotographFullImage).Load();
                    Console.WriteLine("Full Image Size: {0} bytes",
                    photo.PhotographFullImage.HighResolutionBits.Length);
                }
            }
        }

        static void TestBusiness()
        {
            using (var context = new ModelBusiness())
{
                var business = new Business
                {
                    Name = "Corner Dry Cleaning",
                    LicenseNumber = "100x1"
                };
                context.Businesses.Add(business);
                var retail = new Retail
                {
                    Name = "Shop and Save",
                    LicenseNumber =
                "200C",
                    Address = "101 Main",
                    City = "Anytown",
                    State = "TX",
                    ZIPCode = "76106"
                };
                context.Businesses.Add(retail);
                var web = new eCommerce
                {
                    Name = "BuyNow.com",
                    LicenseNumber =
                "300AB",
                    URL = "www.buynow.com"
                };
                context.Businesses.Add(web);
                context.SaveChanges();
            }
            using (var context = new ModelBusiness())
{
                Console.WriteLine("\n--- All Businesses ---");
                foreach (var b in context.Businesses)
                {
                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
                }
                Console.WriteLine("\n--- Retail Businesses ---");
                foreach (var r in context.Businesses.OfType<Retail>())
                {
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                    Console.WriteLine("{0}", r.Address);
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                }
                Console.WriteLine("\n--- eCommerce Businesses ---");
                foreach (var e in context.Businesses.OfType<eCommerce>())
                {
                    Console.WriteLine("{0} (#{1})", e.Name, e.LicenseNumber);
                    Console.WriteLine("Online address is: {0}", e.URL);
                }
            }
        }

        static void TestEmployees()
        {
            using (var context = new ModelEmployee())
{
                var fte = new FullTimeEmployee
                {
                    FirstName = "Jane",
                    LastName =
                "Doe",
                    Salary = 71500M
                };
                context.Employees.Add(fte);
                fte = new FullTimeEmployee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Salary = 62500M
                };
                context.Employees.Add(fte);
                var hourly = new HourlyEmployee
                {
                    FirstName = "Tom",
                    LastName =
                "Jones",
                    Wage = 8.75M
                };
                context.Employees.Add(hourly);
                context.SaveChanges();
            }
            using (var context = new ModelEmployee())
{
                Console.WriteLine("--- All Employees ---");
                foreach (var emp in context.Employees)
                {
                    bool fullTime = emp is HourlyEmployee ? false : true;
                    Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName,
                    fullTime ? "Full Time" : "Hourly");
                }
                Console.WriteLine("--- Full Time ---");
                foreach (var fte in context.Employees.OfType<FullTimeEmployee>())
                {
                    Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName);
                }
                Console.WriteLine("--- Hourly ---");
                foreach (var hourly in context.Employees.OfType<HourlyEmployee>())
                {
                    Console.WriteLine("{0} {1}", hourly.FirstName,
                    hourly.LastName);
                }
            }
        }
    }
}
