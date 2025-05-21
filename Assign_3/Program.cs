/* 0 1 2 3 4 5
1 1 2 3 4 5
2 2 4 6 8 10
3 3 6 9 12 15
...
*/

using System;

class MultiplicationMatrix
{
    static void Main()
    {
        for (int row = 0; row <= 5; row++)
        {
            for (int col = 0; col <= 5; col++)
            {
                Console.Write($"{row * col}\t");
            }
            Console.WriteLine();
        }
    }
}
