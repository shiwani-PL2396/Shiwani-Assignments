using System;

namespace ArrayOperationDelegate
{
    // Delegate that takes an int array and returns an int array
    public delegate int[] ArrayOperation(int[] array);

    internal class Program
    {
        // Sort method
        public static int[] SortArray(int[] array)
        {
            Array.Sort(array);
            return array;
        }

        // Reverse method
        public static int[] ReverseArray(int[] array)
        {
            Array.Reverse(array);
            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'sort' or 'reverse':");
            string choice = Console.ReadLine()?.ToLower();

            int[] numbers = { 5, 2, 8, 1, 9 };

            // Declare delegate variable
            ArrayOperation operation = null;

            // Assign method based on user input
            if (choice == "sort")
            {
                operation = new ArrayOperation(SortArray);
            }
            else if (choice == "reverse")
            {
                operation = new ArrayOperation(ReverseArray);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            // Invoke the delegate
            int[] result = operation(numbers);

            Console.WriteLine("Resulting array: " + string.Join(", ", result));
        }
    }
}
