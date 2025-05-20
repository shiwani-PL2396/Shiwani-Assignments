/* Write a C# program to read the age of a candidate and 
determine whether it is eligible for casting his/her own 
vote  */
using System;

class QuadrantChecker  // Program to check the quadrant of a point
{
    static void Main()  
    {
        Console.Write("Enter X coordinate: ");         //i/p for X coordinate
        int x = Convert.ToInt32(Console.ReadLine());       //  convert i/p to int

        Console.Write("Enter Y coordinate: ");
        int y = Convert.ToInt32(Console.ReadLine());
        // checking for the quadrant
        if (x > 0 && y > 0)        
            Console.WriteLine("First Quadrant");             
        else if (x < 0 && y > 0) 
            Console.WriteLine("Second Quadrant");
        else if (x < 0 && y < 0)
            Console.WriteLine("Third Quadrant");
        else if (x > 0 && y < 0)
            Console.WriteLine("Fourth Quadrant");
        else if (x == 0 && y == 0)
            Console.WriteLine("Origin");
        else if (x == 0)
            Console.WriteLine("Lies on Y axis");
        else
            Console.WriteLine("Lies on X axis");
    }
}
