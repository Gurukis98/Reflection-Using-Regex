using System;
using System.Text.RegularExpressions;

namespace ReflectionRegex_UC_10
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Invalid EMails\n");
            string email1 = "abc";
            string email2 = "abc@.com.my";
            string email3 = "abc123@gmail.a";
            string email4 = "abc123@.com";
            string email5 = "abc123@.com.com";
            string email6 = "abc@abc.com";
            string email7 = "abc()*@gmail.com";
            string email8 = "abc@%*.com";
            string email9 = "abc..2002@gmail.com";
            string email10 = "abc.@gmail.com";
            string email11 = "abc@abc@gmail.com";
            string email12 = "abc@gmail.com.1a";
            string email13 = "abc@gmail.com.aa.au";

            Type type1 = email1.GetType();
            Console.WriteLine(type1);
            if (Regex.Match(email1, "^[a-z]{3}[@]$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type2 = email2.GetType();
            Console.WriteLine(type2);
            if (Regex.Match(email2, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}[a-z]{2}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type3 = email3.GetType();
            Console.WriteLine(type3);
            if (Regex.Match(email3, "^[a-z]{3}[0-9]{3}[@][a-z]{5}[.][a-z]{2}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type4 = email4.GetType();
            Console.WriteLine(type4);
            if (Regex.Match(email4, "^[a-z0-9]{6}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type5 = email5.GetType();
            Console.WriteLine(type5);
            if (Regex.Match(email5, "^[a-z0-9]{6}[@][a-z]{5}[.][a-z]{3}[.][a-z]{2}$").Success)
            {
                Console.WriteLine("EMail is Valid ");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type6 = email6.GetType();
            Console.WriteLine(type6);
            if (Regex.Match(email6, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type7 = email7.GetType();
            Console.WriteLine(type7);
            if (Regex.Match(email7, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type8 = email8.GetType();
            Console.WriteLine(type8);
            if (Regex.Match(email8, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type9 = email9.GetType();
            Console.WriteLine(type9);
            if (Regex.Match(email9, "^[a-z]{3}[.][0-9]{4}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type10 = email10.GetType();
            Console.WriteLine(type10);
            if (Regex.Match(email10, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type11 = email11.GetType();
            Console.WriteLine(type11);
            if (Regex.Match(email11, "^[a-z]{6}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type12 = email12.GetType();
            Console.WriteLine(type12);
            if (Regex.Match(email12, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}[.][a-z]{2}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            Type type13 = email13.GetType();
            Console.WriteLine(type13);
            if (Regex.Match(email13, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}[.][a-z]{2}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid ");
            }
        }
    }
}
