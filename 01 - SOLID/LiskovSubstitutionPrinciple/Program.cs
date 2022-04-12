using LiskovSubstitutionPrinciple.Entities;
using System;

namespace LiskovSubstitutionPrinciple
{
    public class Program
    {
        static public int Area(Rectangle rectangle) => rectangle.Width * rectangle.Height;

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine($"{rectangle} has area {Area(rectangle)}");

            Square square = new Square();
            square.Width = 4;
            Console.WriteLine($"{square} has area {Area(square)}");
        }
    }
}
