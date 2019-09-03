using GeometricShapesLibrary;
using System;

namespace GeometricShapesConsole {
    class Program {

        void Run() { //instance method. New mothods don't have to be static now.

            var quad1 = new Quadrilateral(2, 3, 4, 5);
            Console.WriteLine($"The perimeter of quad1 is {quad1.Perimeter()}");

            var pgram1 = new Parallelogram(6, 7);
            Console.WriteLine($"The perimeter of pgram1 is {pgram1.Perimeter()}, the area is {pgram1.Area()}");

            var square1 = new Square(10);
            Console.WriteLine($"The perimeter of square1 is {square1.Perimeter()}, the area is {square1.Area()}");

            var tri1 = new Triangle(2, 3, 4);
            Console.WriteLine($"The perimeter of tri1 is {tri1.Perimeter()}");

        }

        static void Main(string[] args) {

            var pgm = new Program(); //creating instance of program class
            pgm.Run();
        }
    }
}