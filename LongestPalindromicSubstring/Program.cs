using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string containing a Palindrome: ");
            string paliString = Console.ReadLine();
            int palindromes = 0;
            string palindrome = "";

            for(int i = 0;i<paliString.Length;i++)
            {
                for (int j = 0; j + i < paliString.Length; j++)
                {
                    if (paliString.Substring(j, i).SequenceEqual(paliString.Substring(j, i).Reverse()))
                    {
                        Console.WriteLine(paliString.Substring(j, i));
                        
                        if (paliString.Substring(j,i).Length > palindromes)
                        {
                            palindrome = paliString.Substring(j, i);
                            palindromes = paliString.Substring(j, i).Length;
                        }
                    }
                }            
            }
            Console.WriteLine(palindrome);

            


            Console.ReadKey();

        }




    }
}
