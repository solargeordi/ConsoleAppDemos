namespace Conditions_Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 60)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            Console.WriteLine();

            Console.WriteLine("******* Letter grade if else *****");
            Console.WriteLine();

            Console.Write("Enter grade: ");
            double studentGrade = Convert.ToDouble(Console.ReadLine());

            if (studentGrade >= 90 && studentGrade <= 100)
            {
                Console.WriteLine("A");
            }
            else if (studentGrade >= 80 && studentGrade <= 90)
            {
                Console.WriteLine("B");
            }
            else if (studentGrade >= 70 && studentGrade <= 80)
            {
                Console.WriteLine("C");
            }
            else if (studentGrade >= 60 && studentGrade <= 70)
            {
                Console.WriteLine("D");
            }
            else if (studentGrade >= 1 && studentGrade <= 60)
            {
                Console.WriteLine("F");
            }
            else if (studentGrade == 0)
            {
                Console.WriteLine("Incomplete. Retake!");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine() ;

            //Ternary operator - Used to assign a value to a variable
            //based on a condition.
            Console.WriteLine("******* Ternary Operator *****");
            Console.WriteLine();
            string passStatus = grade < 60 ? "Fail" : "Pass";
            Console.Write($"Final grade: {passStatus} ");
            Console.WriteLine();


            //Switch statements used to evaluate a value & take action
            Console.WriteLine("****** Switch Statement *********");
            /*
             * This accepts an interger as the day of the week
             * then prints the day
            1 - Sunday
            2 - Monday
            3 - Tuesday
            4 - Wednesday
            5 - Thursday
            6 - Friday
            7 - Saturday
            */
            Console.Write("Enter day of the week:");
            int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
            switch (dayOfTheWeek)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednsday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;


            }

            

        }
    }

}
