using System;
using System.Text.RegularExpressions;

namespace ReflectionRegex_UC_7
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters, Atleast 1 Uppercase and Atleast 1 Numeric Number");
            string rule3 = Console.ReadLine();
            Type type = rule3.GetType();
            Console.WriteLine(type);
            if (Regex.Match(rule3, "^[A-Z0-9a-z]{8,}$").Success)
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is Not Valid ");
            }
        }
    }
}
