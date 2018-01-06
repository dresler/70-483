﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lessons._10
{
    public class TaskG
    {
        public static void Run()
        {
            Console.WriteLine(IsValidName("Kent Beck")); // true
            Console.WriteLine(IsValidName("Kent")); // true
            Console.WriteLine(IsValidName("Kent Beck Jr")); // true
            Console.WriteLine(IsValidName("KentBeck")); // false
            Console.WriteLine(IsValidName("Kent  Beck")); // false (two spaces)
            Console.WriteLine(IsValidName("Kent Beck Beck Beck")); // false (too many words)
            Console.WriteLine(IsValidName("Kent BECK")); // false (upper chars on other positions in the word)
        }

        public static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, "^([a-zA-Z]([a-z])* ){0,2}[a-zA-Z][a-z]*$");
        }
    }
}