using System;
using System.Diagnostics;
using System.IO;
using DotLiquid;

namespace LiquidEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            Console.WriteLine("Starting Render");
            var watch = Stopwatch.StartNew();
            Run();
            watch.Stop();
            Console.WriteLine("Time elapsed : " + watch.ElapsedMilliseconds + " ms" );
            Console.ReadKey();
        }

        static void Run()
        {
            var products = new[]
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 1224.54M
                },
                new Product
                {
                    Id = 2,
                    Name = "Sofa 2M",
                    Price = 123.40M
                } 
            };
            //Template.RegisterSafeType(typeof(Product), new[]
            //{
            //    nameof(Product.Id),
            //    nameof(Product.Name),
            //    nameof(Product.Price)
            //});
            var pathSource = "./template.liquid";
            var source = File.ReadAllText(pathSource);
            var template = Template.Parse(source);

            var result = template.Render(Hash.FromAnonymousObject(new
            {
                products
            }));
            Console.WriteLine(result);
        }
    }
}