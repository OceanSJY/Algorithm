using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var intCollection = new List<int>()
            {
                1,
                3,
                22,
                44,
                32,
                5,
                7,
                0,
                11,
                23,
                2,
                2,
                1,
                4,
                56,
                2,
                3,
                6,
                7,
                4,
                8,
                3,
                31,
                5,
                51,
                34,
                4,
                345,
                1,
                23
            };

            var resultFromDynamic = BubbleSortHelper.DynamicBubbleSort(intCollection);
            var resultFromFixed = BubbleSortHelper.FixedBubbleSort(intCollection);
            var resultFromWhile = BubbleSortHelper.BubbleSortByWhile(intCollection);

            Console.ReadLine();
        }
    }
}
