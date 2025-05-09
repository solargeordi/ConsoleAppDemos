namespace ConsoleAppStringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "This is a literal string";
            //Declare without initializing(possible null exception)
            string s2 = "I don't know this either";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            //Initilize to null.
            string s3 = null;
            //Initilize to empty sting
            string s4 = string.Empty; //""
            Console.WriteLine(s4);
            //Escape sequences and characters
            string sentence = "She said, \"I don't know\" \r\nThis is the next line";
            Console.WriteLine(sentence);
            //Verbatim string literal
            string oldpath = "C:\\program files\\programfolder";
            string newpath = @"C:\program files\programfolder";//Don't need extra \ with @
            Console.WriteLine(oldpath);
            Console.WriteLine(newpath);
            //Using a const string to prevent modificaton to a string
            //Don't have to keep typing the path string if i need to use it again
            const string path = "C:\\program files\\programfolder";
            Console.WriteLine(path);
            //Raw string
            string rawLiteral1 = """ This is a literal string """;
            string rawLiteral2 = """
                This is a literal string 
                C:\program files\programfolder
                I don't know
                This is the last line
                """;
            Console.WriteLine(rawLiteral1);
            Console.WriteLine(rawLiteral2);
            //Concatenation and interpolation
            string newString = $"{s1}{s2} Some random text ";
            Console.WriteLine(newString);

            //String manipulation methods & properties
            Console.WriteLine($"Lenght of s1 is {s1.Length}");
            //Sub string
            string subString = s1.Substring(5);
            Console.WriteLine(subString);
            subString = s2.Substring(5, 5);
            Console.WriteLine(subString);

            //Splitting strings
            var splitString = s1.Split(' ');
            Console.WriteLine(splitString);
            for (int i = 0; i < splitString.Length; i++)
            {
                Console.WriteLine(splitString[i]);
            }

            //Replace
            string replacement = s1.Replace('s', '5');
            Console.WriteLine(replacement);

            //Conver to string
            string salary = 112464.77.ToString();
            int anualSalary = 112464;
            string strAnualSalary = anualSalary.ToString();

            //Change Formatting
            Console.WriteLine(anualSalary.ToString("C"));

        }
    }
}
