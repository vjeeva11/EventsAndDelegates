using System;

namespace EventsAndDelegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            FindOddNumbers fo = new FindOddNumbers();
            fo.oddEvent += new FindOddNumbers.OddNumberEvent(AlertMessage);
            fo.Addition(5, 6);
            Console.ReadLine();
        }

        public static void AlertMessage(int a, int b, int result)
        {
            Console.WriteLine("The Addition of {0} and {1} is : {2}", a, b, result);
        }
    }

    class FindOddNumbers
    {
        public delegate void OddNumberEvent(int a, int b, int c);
        public event OddNumberEvent oddEvent;

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Addition(int a, int b)
        {
            int result;
            result = a + b;
            if (result % 2 == 0 | oddEvent != null)
            {
                oddEvent(a, b, result);
            }
            return result;
        }
    }

    public class BaseEventAgrs
    {
        public int Number { get; set; }

        public BaseEventAgrs(int num)
        {
            Number = num;
        }
    }
}
