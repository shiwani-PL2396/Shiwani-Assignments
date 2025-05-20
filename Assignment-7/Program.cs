namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Write a program in C# to convert a binary number into a
decimal number without using array, function and while
loop. */
            Console.WriteLine("Enter a binary number: ");
            int binaryNum = Convert.ToInt32(Console.ReadLine()); // read the binary number
            int decimalNum = 0;                                   // initialize the decimal number
            int baseValue = 1;                                   // initialize the base value
            while (binaryNum > 0)                                // loop until binaryNum is greater than 0
            {
                int lastDigit = binaryNum % 10;                 // get the last digit of the binary number
                decimalNum += lastDigit * baseValue;            // update the decimal number
                baseValue *= 2;                                  // update the base value
                binaryNum /= 10;                                 // remove the last digit from binaryNum
            }
            Console.WriteLine("Decimal equivalent: " + decimalNum); // print the decimal equivalent

            Console.ReadKey();                                    // pause the screen for user to see the result
        }
    }
}
