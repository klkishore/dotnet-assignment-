using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Revrse a string
            string str = "Hello";
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine("reversed string:" + rev);

            // string using palindrome
            string str1 = "madam";
            string rev1 = "";
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                rev1 = rev1 + str1[i];
            }
            if (str == rev)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }

            //revers order of words in a string
            string str2 = "Hello Programming World";
            string[] Words = str2.Split(' ');
            string result = "";
            for (int i = Words.Length - 1; i >= 0; i--)
            {
                result = result + Words[i] + "";
            }
            Console.WriteLine("result.Trim())");
            Console.WriteLine(result);


            //revers each Word in a string

            string str3 = "I love Practice mode";
            string[] words = str3.Split(' ');
            string resul3t = "";

            for (int i = 0; i < words.Length; i++)
            {
                string revs = "";

                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    revs = revs + words[i][j];
                }

                resul3t = resul3t + revs + " ";
            }

            Console.WriteLine(resul3t);

            //count the occurance of each character in a string
            string str4 = "hello";

            for (int i = 0; i < str4.Length; i++)
            {
                bool found = false;

                for (int k = 0; k < i; k++)
                {
                    if (str[i] == str[k])
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    continue;
                }

                int count = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }

                Console.WriteLine(str[i] + " = " + count);

            }
            //remove duplicate characters from a string
            string str5 = "programming";
            string result4 = "";

            for (int i = 0; i < str5.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < result4.Length; j++)
                {
                    if (str5[i] == result4[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    result4 = result4 + str5[i];
                }
            }

            Console.WriteLine("After removing duplicates: " + result);


            //all possible substrings of a string
            string str6 = "abc";

            for (int i = 0; i < str6.Length; i++)
            {
                for (int j = i + 1; j <= str6.Length; j++)
                {
                    string sub = str.Substring(i, j - i);

                    Console.WriteLine(sub);
                }
            }
        }

    }
}