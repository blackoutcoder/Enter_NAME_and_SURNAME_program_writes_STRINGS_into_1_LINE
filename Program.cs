using System;

namespace Enter_NAME_and_SURNAME_program_writes_STRINGS_into_1_LINE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringOperations stringOperations = new StringOperations();
            stringOperations.Reader();
            stringOperations.Cheker();
            stringOperations.Printer();
        }
        public class StringOperations
        {
            public string newString1, newString2;
            string result;

            public void Reader()
            {
                Console.Clear();
                Console.WriteLine("Program places your Name and Surname in one Line");
                Console.WriteLine("Enter your Name and press Enter...");
                newString1 = Console.ReadLine();
                Console.WriteLine("Enter your Surname and press Enter...");
                newString2 = Console.ReadLine();
            }

            public void Cheker()
            {
                if (int.TryParse(newString1,out int num) == true)
                {
                    result = $"You entered an <int> = {num}, pleace enter a <string> for 'Name'" ;
                }
                else if (int.TryParse(newString2, out int num2) == true)
                {

                    result = $"You entered an <int> = {num2}, pleace enter a <string> for 'Surname'";
                }
                else
                {
                    result = $"Your Name: {newString1}, your Surname: {newString2} ";
                }
            }

            public void Printer()
            {
                Console.Clear();
                Console.WriteLine("Program places you entered Name and Surname in one Line");
                Console.WriteLine($"The result is : {result}");
                Console.ReadLine();
            }
        }
    }
}
