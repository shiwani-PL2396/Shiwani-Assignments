namespace Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  C Write a C# Program to display the following pattern
  using the alphabet.
  A
  A B A
  A B C B A
  A B C D C B A     */
            Console.WriteLine("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());   
            for (int i = 1; i <= n; i++)                 // outer loop(row) from 1 to n
            {
                char ch = 'A';                            // initialize the character
                for (int j = 1; j <= i; j++)             // loop from 1 to i
                {
                    Console.Write(ch + " ");              // print the character
                    ch++;                                  // increment the character
                }
                ch--;                                      // decrement the character
                for (int j = 1; j < i; j++)               // loop from 1 to i-1
                {
                    Console.Write(ch + " ");              // print the character
                    ch--;                                  // decrement the character
                }
                Console.WriteLine();                       // print a new line
            }
            Console.ReadKey();                            // pause the screen for user to see the result
        }
    }
}
