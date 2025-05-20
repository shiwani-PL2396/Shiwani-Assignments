
namespace 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to read roll no, name and marks of
            three subjects and calculate the total, percentage and
            division*/
     
                int rollNo;
                string name;
                int marks1, marks2, marks3;
                int total;
                float percentage;

                // Read student details
                Console.Write("Enter Roll Number: ");
                rollNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                name = Console.ReadLine();

                Console.Write("Enter Marks of Subject 1: ");
                marks1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Marks of Subject 2: ");
                marks2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Marks of Subject 3: ");
                marks3 = Convert.ToInt32(Console.ReadLine());

                // Calculate total and percentage
                total = marks1 + marks2 + marks3;
                percentage = total /3;

            // Display results
            Console.WriteLine("\n--- Student Result ---");
                Console.WriteLine("Roll No   : " + rollNo);
                Console.WriteLine("Name      : " + name);
                Console.WriteLine("Total     : " + total);
                Console.WriteLine("Percentage: " + percentage + "%");

                // Determine division
                if (percentage >= 60)
                    Console.WriteLine("Division  : First");
                else if (percentage >= 50)
                    Console.WriteLine("Division  : Second");
                else if (percentage >= 40)
                    Console.WriteLine("Division  : Third");
                else
                    Console.WriteLine("Division  : Fail");

                Console.ReadLine();
            }
        }



    }
}
}
