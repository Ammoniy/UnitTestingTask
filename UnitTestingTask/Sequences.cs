using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitTestingTask
{
    public static class MaxNumberOF
    {
        public static int Sequence(string str)
        {

            if (String.IsNullOrEmpty(str))
            {
                return 0;
            }
            int count = 1, comparer = 0, result = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    count++;
                    result = Math.Max(comparer, count);
                }
                else
                {
                    comparer = Math.Max(result, count);
                    count = 1;
                }
            }

            Console.WriteLine(result);

            return result;
        }

        public static int SequenceOfLatin(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return 0;
            }
            int count = 1, comparer = 0, result = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1] && Regex.IsMatch(str[i].ToString(), @"[a-zA-Z ]") && Regex.IsMatch(str[i + 1].ToString(), @"[a-zA-Z ]"))
                {
                    count++;
                    result = Math.Max(comparer, count);
                }
                else
                {
                    comparer = Math.Max(result, count);
                    count = 1;
                }
            }

            Console.WriteLine(result);

            return result;
        }

        public static int SequenceOfDigits(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return 0;
            }
            int count = 1, comparer = 0, result = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1] && Regex.IsMatch(str[i].ToString(), @"[0-9]") && Regex.IsMatch(str[i + 1].ToString(), @"[0-9]"))
                {
                    count++;
                    result = Math.Max(comparer, count);
                }
                else
                {
                    comparer = Math.Max(result, count);
                    count = 1;
                }
            }

            Console.WriteLine(result);

            return result;
        }
    }

    internal class Sequences
    {
        static void Main(string[] args)
        {
            MaxNumberOF.SequenceOfDigits("2111113sssses12312333333312");
        }
    }
}
