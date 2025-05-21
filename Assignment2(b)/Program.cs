using System;

class MathProgram
{
    /*  Design a class Math consists of the methods   add (), subtract (), multiply () 
and divide () operations which will return the respective values. Design an 
interface which will call the methods.  */
    static void Main()
    {
        MathOperations math = new MathOperations();

        Console.WriteLine($"Add: {math.Add(10, 5)}");
        Console.WriteLine($"Subtract: {math.Subtract(10, 5)}");
        Console.WriteLine($"Multiply: {math.Multiply(10, 5)}");
        Console.WriteLine($"Divide: {math.Divide(10, 5)}");

        Console.ReadLine();
    }
}
