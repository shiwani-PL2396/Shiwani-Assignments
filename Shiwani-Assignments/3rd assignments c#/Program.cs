namespace _3rd_assignments_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y
            //*Write a C# Sharp program to display certain values of 
            //*the function x = y2 + 2y + 1(using integer numbers for y,
            //*ranging from - 5 to + 5).//*
            Console.WriteLine("enter a no. b/w - 5 to + 5");
              y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x = y * y + 2 * y + 1");   //(y+1)^2
            Console.WriteLine("x = {0}", y * y + 2 * y + 1);



        }
    }
}