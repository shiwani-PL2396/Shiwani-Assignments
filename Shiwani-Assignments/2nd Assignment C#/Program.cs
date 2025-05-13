namespace _2nd_Assignment_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program that takes distance and time 
as input and displays the speed in kilometers per hour 
and miles per hour.  */
            // Input: Distance
            Console.Write("Enter the distance (in kilometers): ");
            double distanceKm = Convert.ToDouble(Console.ReadLine());

            // Input: Time
            Console.Write("Enter the time - hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the time - minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            // Convert total time to hours
            double totalTimeInHours = hours + (minutes / 60.0);

            if (totalTimeInHours <= 0)
            {
                Console.WriteLine("Time must be greater than zero.");
                return;
            }

            // we will Calculate speed
            double speedKmPerHour = distanceKm / totalTimeInHours;
            double speedMilesPerHour = speedKmPerHour * 0.621371; // 1 km = 0.621371 miles

            // display Output
            Console.WriteLine($"\nSpeed in kilometers per hour: {speedKmPerHour:F2} km/h");
            Console.WriteLine($"Speed in miles per hour: {speedMilesPerHour:F2} mph");

            Console.ReadLine();
        }
    }
}
