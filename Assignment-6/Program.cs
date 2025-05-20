namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Write a program in C# to check whether a number is a
 palindrome or not. */

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine()); // read the number
            int originalNum = num;                          // store the original number
            int reversedNum = 0;                            // initialize the reversed number
            while (num > 0)                                 // loop until num is greater than 0
            {
                int digit = num % 10;                      // get the last digit
                reversedNum = reversedNum * 10 + digit;     // update the reversed number
                num /= 10;                                  // remove the last digit from num
            }
            if (originalNum == reversedNum)                 // check if the original number is equal to the reversed number
            {
                Console.WriteLine("{0} is a palindrome.", originalNum); // print that it's a palindrome
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome.", originalNum); // print that it's not a palindrome
            }
            Console.ReadKey();                              // pause the screen for user to see the result
        }
    }
}
