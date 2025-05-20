namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# to display the first n terms of
Fibonacci series. */

            Console.WriteLine("Enter the number of terms in the Fibonacci series: ");
            int n = Convert.ToInt32(Console.ReadLine());         // read the number of terms
            int a = 0, b = 1, c;                               // initialize the first two terms
            Console.WriteLine("Fibonacci series: ");
            Console.Write(a + " " + b + " ");                 // print the first two terms
            for (int i = 2; i < n; i++)                       // loop from 2 to n
            {
                c = a + b;                                    // calculate the next term
                Console.Write(c + " ");                       // print the next term
                a = b;                                       // update a to b
                b = c;                                       // update b to c
            }
            Console.ReadKey();                 // pause the screen for user to see the result
        }
    }
}
