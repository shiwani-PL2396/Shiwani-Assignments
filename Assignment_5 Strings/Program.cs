namespace Assignment_5_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# to count a total number of 
           alphabets, digits and special characters in a string */

            Console.WriteLine(
                "Enter a string to count the number of alphabets, digits, and special characters:");
            string str = Console.ReadLine();
            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else if (!char.IsWhiteSpace(c))
                {
                    specialCharCount++;
                }

            }

            Console.ReadLine();

        }
    }
}
