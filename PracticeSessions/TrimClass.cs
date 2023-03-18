using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSessions
{
    public class TrimClass : IPracticeClass
    {

        public string StringToTrim { get; set; } = "---abc---xyz----";

        public char[] CharArrayToTrim { get; set; } = { '*', ' ', '\'' };

        public TrimClass(string stringToTrim, char[] charArrayToTrim)
        {
            StringToTrim = stringToTrim;
            CharArrayToTrim = charArrayToTrim;
        }

        public void Execute()
        {
            TrimMethod();

            if (CharArrayToTrim.Length == 1)
            {
                TrimCharMethod(CharArrayToTrim[0]);
                return;
            }
            
            TrimCharArrayMethod();

        }

        private void TrimMethod()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your middle name or initial: ");
            string middleName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("You entered '{0}', '{1}', and '{2}'.",
                            firstName, middleName, lastName);

            string name = ((firstName.Trim() + " " + middleName.Trim()).Trim() + " " +
                        lastName.Trim()).Trim();
            string nameWithoutTrim = (firstName.Trim() + " " + middleName.Trim() + " " +
                        lastName.Trim()).Trim();
            Console.WriteLine("The result is " + name + ".");
            Console.WriteLine("The result is " + nameWithoutTrim + ".");

            Console.ReadKey();


            // The following is a possible output from this example:
            //       Enter your first name:    John
            //       Enter your middle name or initial:
            //       Enter your last name:    Doe
            //       
            //       You entered '   John  ', '', and '   Doe'.
            //       The result is John Doe.
        }


        private void TrimCharMethod(char trimChar)
        {

            trimChar = '-';   //Explicit

            Console.WriteLine("Before Trimming: " + StringToTrim);
            Console.WriteLine("After Trimming: " + StringToTrim.Trim(trimChar));

            Console.WriteLine("After Trimming at Start: " + StringToTrim.TrimStart(trimChar));
            Console.WriteLine("After Trimming at End: " + StringToTrim.TrimEnd(trimChar));
        }


        /* Removes all leading and trailing occurrences of a set of characters specified in an array from
          the current string. */
        private void TrimCharArrayMethod()
        {
            string banner = "*** Much Ado About Nothing ***";

            string result = banner.Trim(CharArrayToTrim);

            Console.WriteLine("Trimmed\n   {0}\nto\n   '{1}'", banner, result);

            /*The following example uses the Trim(System.Char[]) method to remove space, asterisk (*),
            and apostrophe (') characters from a string. */

            // The example displays the following output:
            //       Trimmed
            //          *** Much Ado About Nothing ***
            //       to
            //          'Much Ado About Nothing'
        }
    }
}
