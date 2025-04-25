namespace ConsoleAppUserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string firstName = string.Empty;
            string lastName = string.Empty;

            int age = 0;
            int retirementAge = 65;

            //Prompt user for input
            Console.WriteLine("Enter your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            
            int workingYearsRemaining = retirementAge - age;
            Console.WriteLine($"Name: {firstName} {lastName} ");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Working years remaining: {workingYearsRemaining}");



        }
    }
}
