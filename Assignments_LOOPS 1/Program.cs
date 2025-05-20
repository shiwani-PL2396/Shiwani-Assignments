namespace Assignments_LOOPS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region pattern
            // set limit
            int limit = 5;
            for (int i = 1; i <=limit; i++) 
            {
                // print numbers
                for (int j=i; j <limit ; j++) 
                {
                    Console.Write(" ");
                }
                // print stars
                for (int k = 1; k <= i; k++) 
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
                #endregion
            }
        }

        }
