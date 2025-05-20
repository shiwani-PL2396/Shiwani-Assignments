namespace Assignment_6_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# to extract a substring from a 
           given string without using the library function */

            Console.WriteLine("Enter a string:");          //input string
            string str = Console.ReadLine();
            Console.WriteLine("Enter the starting index for the substring:");  //input starting index
            int startIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the substring:");  //input length of substring
            int length = int.Parse(Console.ReadLine());
            string substring = ExtractSubstring(str, startIndex, length);    //function call
                
            Console.WriteLine("Extracted substring: " + substring);  //output substring

            Console.ReadLine();  //wait for user input


        }
    }
}
