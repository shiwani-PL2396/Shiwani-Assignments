/* 1
   2 1
   3 2 1
   4 3 2 1
*/

using System;

class NumberPattern
{
    static void Main()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
