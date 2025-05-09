namespace ConsoleAppExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You are {age} years old");
            }
            catch (Exception) 
            {
                Console.WriteLine("Enter a number only.");

            }
            

        }
    }
}
