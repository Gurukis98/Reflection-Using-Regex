using System;
using System.Text.RegularExpressions;

namespace ReflectionRegex_UC_6
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters and 1 Uppercase");
            string rule2 = Console.ReadLine();
            Type type = rule2.GetType();
            Console.WriteLine(type);
            if (Regex.Match(rule2, "^[A-Za-z]{8,}$").Success)
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
