using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.AnagramCheck("reheat", "heater");
        }

        public void AnagramCheck(String a, String b)
        {
            if (a.Length == b.Length)
            {
                Char[] string1 = a.ToLower().ToCharArray();
                Char[] string2 = b.ToLower().ToCharArray();

                Console.WriteLine(string1);
                Console.WriteLine(string2);

                Array.Sort(string1);
                Array.Sort(string2);

                Console.WriteLine(string1);
                Console.WriteLine(string2);

                String a1 = string1.ToString();
                String b1 = string2.ToString();

                if (a1.Equals(b1))
                {
                    Console.WriteLine("Both strings are Anagram.");
                }

            }
            else
            {
                Console.WriteLine("Both strings are NOT Anagram.");
            }

            Console.ReadLine();
        }
    }
}

