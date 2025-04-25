namespace ConsoleAppVariableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            text - string
            integers - int
            decimal - double, float, decimal
            logical - bool
            */
            string name = "Tyron Logan";
            Console.WriteLine(name);
            Console.WriteLine("This is " + name);//String concatenation
            Console.WriteLine($"This is {name}");//String interpolation
            Console.WriteLine("This is {0}", name);//Formatted string

            int age = 54;
            int retirementYearsLeft = 11;
            int retirementAge = age + retirementYearsLeft;
            Console.WriteLine(age);
            Console.WriteLine("Tyron is: " + age);
            Console.WriteLine("Tyron retirement age: " + retirementAge);

            bool isRetired = false;
            Console.WriteLine("Is he retired? " + isRetired);

        }
    }
}
