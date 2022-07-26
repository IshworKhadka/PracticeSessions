﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSessions
{
    public class GuidClass
    {
        

        public void GuidMethods() 
        {
            Guid obj = Guid.NewGuid();
            Console.WriteLine("New Guid is: " + obj.ToString());
            //Try this, need more clarification
            Console.WriteLine("New Guid is: (need more clarification without ToString()) " + obj);

            //Avoid this, since it will always be 16 byte with all 0.
            Guid guid = new Guid();
            Console.WriteLine("New Guid is: " + guid.ToString());

            Console.WriteLine("Emply String: " + Guid.Empty);
            Console.WriteLine();

            Console.WriteLine("------Ref keyword---------------");

            var initialGuid = Guid.NewGuid();
            Console.WriteLine("Before: " + initialGuid);
            updateGuid(ref initialGuid);
            Console.WriteLine("After: " + initialGuid);
            Console.WriteLine();

            Console.WriteLine("------Parsing---------------");
            Console.WriteLine("the first one works only if the input string has a valid value, the second one tries to parse a value and assign it to a variable.");

            var guid1 = Guid.Parse("fc072692-d322-448b-9b1b-ba3443943579");
            Console.WriteLine("Guid1: " + guid1);

            Guid.TryParse("fc072692-d322-448b-9b1b-ba3443943579", out var guid2);
            Console.WriteLine("Guid2: " + guid2);

            Console.WriteLine();
            Console.WriteLine("You can also use the simple constructor, like");
            var guid3 = new Guid("fc072692-d322-448b-9b1b-ba3443943579");

            Console.WriteLine("Guid3: " + guid3);

            Console.WriteLine();
            Console.WriteLine("Can use a byte array as an input to the constructor, and have it converted to Guid. Of course, the array must be of 16 bytes.");
            var bytes = new byte[16];
            var guid4 = new Guid(bytes);
            Console.WriteLine("Guid4: " + guid4);

            Console.WriteLine();
            Console.WriteLine("----------A Guid has multiple formats-----------");
            var tmpGuid = Guid.NewGuid();
            Console.WriteLine("D: 32 digits, but with the hyphens. This is the default");
            Console.WriteLine("D \t" + tmpGuid.ToString("D"));
            Console.WriteLine("N: 32 digits, without any other symbols");
            Console.WriteLine("N \t" + tmpGuid.ToString("N"));
            Console.WriteLine("B: here we have the hyphens, and the string is enclosed in braces");
            Console.WriteLine("B \t" + tmpGuid.ToString("B"));
            Console.WriteLine("P: similar to B, but with parentheses instead of braces");
            Console.WriteLine("P \t" + tmpGuid.ToString("P"));
            Console.WriteLine("X: here we have the hexadecimal representation of the guid");
            Console.WriteLine("X \t" + tmpGuid.ToString("X"));


        }

        private static void updateGuid(ref Guid tmpGuid)
        {
            tmpGuid = Guid.NewGuid();
        }
    }
}
