namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //void methods - complete a task without returning a value
            void printName()
            {
                Console.WriteLine("Method");

            }

            //Value returning methods - returns a value after operation
            int getFiveYearsAgo()
            {
                int year = DateTime.Now.AddYears(-5).Year;
                return year;
            }
            //method with parameters
            void nameWithParameters(string name)
            {
                Console.WriteLine(name);
            }
            int yearDiffWithParam(int year)
            {
                int yearDiff = DateTime.Now.Year - year;
                return yearDiff;
            }

            //methods with optional parameters
            int getFutureOrPassYear(int numberOfYears = 0)
            {
                var year = DateTime.Now.AddYears(numberOfYears).Year;
                return year;
            }
            
            //methods with nullable parameters
            void printNameNullableParam(string? name, int? count)
            {
                name ??= "Default Name";
                count ??= 1;

                for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(name);
                    }
            }

            //Function(Method) Calls
            //printName();
            //int fiveYearsAgo = getFiveYearsAgo();
            //Console.WriteLine("Five years ago was: " + fiveYearsAgo);

            //Console.Write("Enter name: ");
            //string name1 = Console.ReadLine();
            //nameWithParameters(name1);

            //Console.Write("Enter a year: ");
            //int yearEntered = Convert.ToInt32(Console.ReadLine());
            //int yearsAgo = yearDiffWithParam(yearEntered);
            //Console.WriteLine("This was " + yearsAgo + " years ago");

            Console.Write("Number of years: ");
            int numberOfYears = Convert.ToInt32(Console.ReadLine());
            var pastYear1 = getFutureOrPassYear();
            Console.WriteLine($"This is the year: " + pastYear1);
            var pastYear2 = getFutureOrPassYear(numberOfYears);
            Console.WriteLine($"This is the year: " + pastYear2);

            printNameNullableParam(null, null);






        }
    }
}
