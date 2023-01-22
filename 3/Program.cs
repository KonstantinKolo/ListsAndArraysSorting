using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ', ',', '/', '!', '.', '[', '[', '(', ')', ':', ';', '"').ToList();
            List<string> lowerList = new List<string>();
            List<string> upperList = new List<string>();
            List<string> mixedList = new List<string>();
            bool checkSym = false;
            string raw = string.Join(" ", list);
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            raw = regex.Replace(raw, " ");
            list = raw.Split(' ').ToList();
            foreach(string sort in list)
            {
                checkSym = sort.Any(ch => !char.IsLetterOrDigit(ch));
                if (sort == sort.ToLower() && sort != Regex.Match(sort, @"\d+").Value && checkSym == false)
                {
                    lowerList.Add(sort);
                }
                else if (sort == sort.ToUpper() && sort != Regex.Match(sort, @"\d+").Value && checkSym == false)
                {
                    upperList.Add(sort);
                }
                else
                {
                    mixedList.Add(sort);
                }
            }
            Console.WriteLine("Lower-case : " + string.Join(", ",lowerList));
            Console.WriteLine("Upper-case : " + string.Join(", ", upperList));
            Console.WriteLine("Mixed-case : " + string.Join(", ", mixedList));
        }
    }
}
