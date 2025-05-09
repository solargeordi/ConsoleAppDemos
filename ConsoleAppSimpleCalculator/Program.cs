namespace ConsoleAppSimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            //Show calculator options
            Console.WriteLine("Enter operation");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int answer = 0;
            switch (choice)
            {
                case 1: 
                    answer = num1 + num2;
                    break;
                case 2:
                    answer = num1 - num2;
                    break;
                case 3:
                    answer = num1 * num2;
                    break;
                case 4:
                    answer = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                break;

            }
            Console.WriteLine($"Results is: {answer}");



        }
    }
}
