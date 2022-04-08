using OpenClosedPrinciple.Entities;
using OpenClosedPrinciple.Enums;
using OpenClosedPrinciple.Extensions;
using System;

namespace OpenClosedPrinciple
{

    public class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var betterFilter = new BetterFilter();

            Console.WriteLine("Green products (new):");
            foreach (var product in betterFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {product.Name} is green");
            }

            Console.WriteLine("Large blue items");
            foreach (var product in betterFilter.Filter(products,
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeSpecification(Size.Large)
                    )))
            {
                Console.WriteLine($" - {product.Name} is big and blue");
            }

        }
    }

}
