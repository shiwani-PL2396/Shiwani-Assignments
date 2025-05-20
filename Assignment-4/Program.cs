namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# to find the prime numbers within
a range of numbers */
ConsoleKeyInfo key = Console.ReadKey();         // wait for user input
            Console.ReadKey();                  // pause the screen for user to see the result
            Console.WriteLine("Enter the starting number of the range: ");
            int start = Convert.ToInt32(Console.ReadLine());      // read the starting number
            Console.WriteLine("Enter the ending number of the range: ");
            int end = Convert.ToInt32(Console.ReadLine());        // read the ending number
            Console.WriteLine("The prime numbers between {0} and {1} are: ", start, end);
            for (int i = start; i <= end; i++)           // loop from start to end
            {
                bool isPrime = true;                      // assume the number is prime
                if (i < 2)                               // check if the number is less than 2
                {
                    isPrime = false;                     // if so, it's not prime
                }
                else
                {
                    for (int j = 2; j <= Math.Sqrt(i); j++) // loop from 2 to the square root of the number
                    {
                        if (i % j == 0)                 // check if the number is divisible by j
                        {
                            isPrime = false;             // if so, it's not prime
                            break;                       // exit the loop
                        }
                    }
                }
                if (isPrime)                             // check if the number is prime
                {
                    Console.Write(i + " ");            // print the prime number
                }
                Console.WriteLine();                 // print a new line
            }

Console.ReadKey();                  // pause the screen for user to see the result  

        }
    }
}
