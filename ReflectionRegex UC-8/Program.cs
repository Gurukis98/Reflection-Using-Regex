using System;
using System.Text.RegularExpressions;

namespace ReflectionRegex_UC_8
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters, Atleast 1 Uppercase, Atleast 1 Numeric Number and Exactly 1 Special Character");
            string rule4 = Console.ReadLine();
            Type type = rule4.GetType();
            Console.WriteLine(type);
            if (Regex.Match(rule4, "^[A-Z0-9a-z~,`!@#$%^&*()_./?'+{}:;<>]{8,}$").Success)
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is Not Valid");
            }
        }
    }
}
