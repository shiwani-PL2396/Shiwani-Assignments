namespace Assignment_2_Strings
{
    internal class Program
    {
        /* Write a program in C# to print individual characters of 
       the string in reverse order */
        static void Main(string[] args)
        {
            string str = "Hello Shiwani";
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("Reversed string: " + new string(charArray));
            Console.ReadLine();
        }
        static void PrintIndividualCharacters(string str)














        {
         }
    }
}
