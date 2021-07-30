using System;
using System.Text.RegularExpressions;

namespace ReflectionRegex_UC_9
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Eight EMails\n");
            string email1 = "abc@yahoo.com";
            string email2 = "abc-100@yahoo.com";
            string email3 = "abc.100@yahoo.com";
            string email4 = "abc111@abc.com";
            string email5 = "abc.100@abc.com.au";
            string email6 = "abc@1.com";
            string email7 = "abc@gmail.com.com";
            string email8 = "abc+100@gmail.com";

            Type type = email1.GetType();
            Console.WriteLine(type);
            if (Regex.Match(email1, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type1 = email2.GetType();
            Console.WriteLine(type1);
            if (Regex.Match(email2, "^[a-z]{3}[-][0-9]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type2 = email3.GetType();
            Console.WriteLine(type2);
            if (Regex.Match(email3, "^[a-z]{3}[.][0-9]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type3 = email4.GetType();
            Console.WriteLine(type3);
            if (Regex.Match(email4, "^[a-z0-9]{6}[@][a-z]{3}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid ");
            }

            Type type4 = email5.GetType();
            Console.WriteLine(type4);
            if (Regex.Match(email5, "^[a-z]{3}[.][0-9]{3}[@][a-z]{3}[.][a-z]{3}.[a-z]{2}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type5 = email6.GetType();
            Console.WriteLine(type5);
            if (Regex.Match(email6, "^[a-z]{3}[@][0-9]{1}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type6 = email7.GetType();
            Console.WriteLine(type6);
            if (Regex.Match(email7, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type7 = email8.GetType();
            Console.WriteLine(type7);
            if (Regex.Match(email8, "^[a-z]{3}[+][0-9]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
        }
    }
}
