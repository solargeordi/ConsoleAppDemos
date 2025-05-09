namespace ConsoleAppLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hi");
            }


            /* Console.Write("Enter number of times to print:");
             int userCount = Convert.ToInt32(Console.ReadLine());
             for (int i  = 0; i < userCount; i++)
             {
                 Console.WriteLine("Print this ");
             }*/

            Console.WriteLine("********* While loop below *************");

            int counter = 0;
            while (counter < 12)
            {
                Console.WriteLine($"Print this - {counter}");
                counter += 3;
            }

            Console.Write("Enter number of times to print:");
            int userCount = Convert.ToInt32(Console.ReadLine());
            while (userCount == 0)
            {
                Console.WriteLine($"Print this - {counter}");
                
            }
        }
    }
}
