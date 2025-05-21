using System;

class RectangleProgram
{
    /* Design a class Rectangle consists of two attributes x-coordinate and y
coordinate. Design two constructors and methods for setting and getting the 
attributes of class Rectangle. Incorporate   a method getArea() to compute the 
area of the Rectangle.  */
    static void Main()
    {
        Rectangle rect = new Rectangle(10, 5);
        Console.WriteLine($"Area of Rectangle: {rect.GetArea()}");

        Console.ReadLine();
    }
}
