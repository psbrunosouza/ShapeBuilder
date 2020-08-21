using ShapeBuilder.Entities;
using ShapeBuilder.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ShapeBuilder {
    class Program {
        static void Main(string[] args) {

            /*
             Essa pequena demonstracao de sistema, tem o objetivo de servir de estudo para classes abstratas
            e metodos abstratos.
             */

            // Lista do tipo Shape, mesmo sendo uma classe abstrata, ainda possibilita o polimorfismo 
            // permitindo que subclasses possam ser classificadas com o mesmo tipo.
            List<Shape> shapes = new List<Shape>(); 

            //O codigo abaixo tem por fim, criar e definir as formas (RETANGULO E CIRCULO)
            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Shape #{i}: ");
                Console.Write("Rectangle or Circle (r/c): ");
                char typeShape = char.Parse(Console.ReadLine());
                Console.Write("Color (BLACK/ BLUE/ RED): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (typeShape == 'r') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    shapes.Add(new Rectangle(color, width, height));
                }
                else if (typeShape == 'c') {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    shapes.Add(new Circle(color, radius));
                }

            }

            //Apresentar as formas criadas anteriormente e suas respectivas areas
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape s in shapes) {
                Console.WriteLine(s.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
