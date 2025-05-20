using System;
using System.Collections.Generic;
using System.Linq;

class RemoveElementsProgram
{ /* From a given list of numbers, remove elements if:
      It is an even number
      It is a duplicate element */

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8 };

        var filtered = numbers
            .GroupBy(n => n)
            .Where(g => g.Count() == 1 && g.Key % 2 != 0) // not duplicate, and odd
            .Select(g => g.Key)
            .ToList();

        Console.WriteLine("Filtered List (odd & unique):");
        Console.WriteLine(string.Join(", ", filtered));
    }
}
