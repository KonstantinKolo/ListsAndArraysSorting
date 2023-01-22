using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> answerList = list.ToList();
            foreach (double number in list)
            {
                if (Math.Sqrt(number) != Math.Round(Math.Sqrt(number)))
                {
                    answerList.Remove(number);
                }
            }
            answerList.Sort();
            answerList.Reverse();
            Console.WriteLine(string.Join(" ", answerList));
        }
    }
}
