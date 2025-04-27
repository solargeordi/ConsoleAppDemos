namespace ConsoleAppOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;
            //Modulus means divide two num and give me the remainder
            int mod = num1 % num2;
            Console.WriteLine();
            Console.WriteLine("***************Math Results***********");
            Console.WriteLine($"Sum " + sum);
            Console.WriteLine($"Difference " + difference);
            Console.WriteLine($"Product " + product);
            Console.WriteLine($"Quotient " + quotient);

            bool isGreaterThan = num1 > num2;
            bool isLessThan = num1 < num2;
            bool isEqualTo = num1 == num2;
            bool isGreaterEqual = num1 >= num2;
            bool isLessEqual = num1 <= num2;
            bool isNotEqual = num1 != num2;
            Console.WriteLine();
            Console.WriteLine("***************Logic Results***********");

            Console.WriteLine($"Greater than: {isGreaterThan}");
            Console.WriteLine($"Less than: {isLessThan}");
            Console.WriteLine($"Equal to: {isEqualTo}");
            Console.WriteLine($"Greater than or equal: {isGreaterEqual}");
            Console.WriteLine($"Less than or equal: {isLessEqual}");
            Console.WriteLine($"Equal to: {isEqualTo}");
            Console.WriteLine($"Not equal to: {isNotEqual}");

            Console.WriteLine("***************Assignment Results***********");
            Console.WriteLine();
            Console.Write("Enter a number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            num1 += num3;
            Console.WriteLine($"Number increase to; {num1}");
            num1 -= num3;
            Console.WriteLine($"Number decrease to; {num1}");
            num1 /= num3;
            Console.WriteLine($"Number divided; {num1}");
            num1 *= num3;
            Console.WriteLine($"Number multiplied; {num1}");
            num1 %= num3;
            Console.WriteLine($"Number mod; {num1}");


        }
    }
}
