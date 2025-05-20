namespace Assignment_3_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Write a program in C# to count the total number of 
words in a string */
            string str = "Hello Shiwani";
            int wordCount = 0;
            bool isWord = false;
            int endOfLine = str.Length - 1;
            for (int i = 0; i < str.Length; i++)
            {
                // if the char is a letter and there is no char before it, 
                // we have found a new word
                if (char.IsLetter(str[i]) && (i == 0 || str[i - 1] == ' '))
                {
                    isWord = true;
                }
                // if the char is not a letter and there was a char before it, 
                // we have reached the end of a word
                else if (!char.IsLetter(str[i]) && isWord)
                {
                    isWord = false;
                    wordCount++;
                }
            }
            // if the last char in the string was a letter, 
            // we have found a new word
            if (isWord)
            {
                wordCount++;
            }
            Console.WriteLine("Total number of words: " + wordCount);
            Console.ReadLine();
        }
    }
}
