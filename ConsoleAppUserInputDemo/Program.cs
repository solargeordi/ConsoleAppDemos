using System.Globalization;

namespace ConsoleAppUserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            const int retirementAge = 65;
            string? firstName = string.Empty;//adding ? allows a null(nothing) entry
            string lastName = string.Empty;
            int age;
            DateOnly dob = new DateOnly();
            decimal salary;
            char? gender;
            bool working;

            //Prompt user for input
            Console.Write("Enter your first name:");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name:");
            lastName = Console.ReadLine();

            Console.Write("Enter your DOB (dd/mm/yyyy):");
            dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
            age = DateTime.Now.Year - dob.Year;

            Console.Write("Enter your salary:");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("What is your gender? (M or F)");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working? (true or fale)");
            working = Convert.ToBoolean(Console.ReadLine());

            int workingYearsRemaining = retirementAge - age;
            var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining);

            Console.WriteLine($"Name: {firstName} {lastName} ");
            Console.WriteLine($"Age: {age}");
   
            Console.WriteLine($"Salay: {salary.ToString("C")}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Working: {working}");
            Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
            Console.WriteLine($"Estimated Retirement year: {estimatedRetirementDate.Year}");


        }
    }
}
