namespace ConsoleAppUserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string name = string.Empty;
            int age = 0;
            int retirementAge = 65;

            //Prompt user for input
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            
            int workingYearsRemaining = retirementAge - age;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Working years remaining: {workingYearsRemaining}");



        }
    }
}
