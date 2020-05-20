using System;
using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enums;
using System.Globalization;
using System.Collections.Generic;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char esc = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (esc == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Shape Areas:");
            foreach(Shape sh in list)
            {
                Console.WriteLine("Color: " +sh.Color);
                Console.WriteLine(sh.Area().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
                
            }

        }
    }
}
