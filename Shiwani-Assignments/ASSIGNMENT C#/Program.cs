using System.Reflection.Metadata;

namespace ASSIGNMENT_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program that takes a number and a 
            width also a number, as input and then displays an area & perimeter of a triangle. */
            Console.WriteLine("Enter the three sides of the triangle :");
            Console.Write("Side A = ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side C: ");
            double sideC = Convert.ToDouble(Console.ReadLine());
            double perimetre = (sideA + sideB + sideC) / 2;
            Console.WriteLine($"Perimeter of the triangle: {perimetre}");

            //Formula for Area
            double area = Math.Sqrt(perimetre * (perimetre - sideA) * (perimetre - sideB) * (perimetre - sideC));
            Console.WriteLine($"Area of the triangle: {area}");

            Console.ReadLine();


        }
    }
}
