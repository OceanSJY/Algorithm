using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    /// <summary>
    /// The bubble sort helper
    /// </summary>
    public class BubbleSortHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intCollection"></param>
        /// <returns></returns>
        public static IEnumerable<int> DynamicBubbleSort(IEnumerable<int> intCollection)
        {
            var intArray = intCollection.ToArray();

            for (var i = 0; i < intArray.Length; i++)
            {
                for (var j = 0; j < intArray.Length - 1 - i; j++)
                {
                    if (intArray[j] <= intArray[j + 1])
                    {
                        continue;
                    }

                    var temp = intArray[j];
                    intArray[j] = intArray[j + 1];
                    intArray[j + 1] = temp;
                }
            }

            return intArray;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="intCollection"></param>
        /// <returns></returns>
        public static IEnumerable<int> FixedBubbleSort(IEnumerable<int> intCollection)
        {
            var intArray = intCollection.ToArray();

            for (var i = 0; i < intArray.Length; i++)
            {
                for (var j = 0; j < intArray.Length; j++)
                {
                    if (intArray[i] >= intArray[j])
                    {
                        continue;
                    }

                    var temp = intArray[i];
                    intArray[i] = intArray[j];
                    intArray[j] = temp;
                }
            }

            return intArray;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="intCollection"></param>
        /// <returns></returns>
        public static IEnumerable<int> BubbleSortByWhile(IEnumerable<int> intCollection)
        {
            var intArray = intCollection.ToArray();
            var swapped = true;

            do
            {
                swapped = false;
                for (var i = 0; i < intArray.Length - 1; i++)
                {
                    if (intArray[i] <= intArray[i + 1])
                    {
                        continue;
                    }

                    var temp = intArray[i];
                    intArray[i] = intArray[i + 1];
                    intArray[i + 1] = temp;

                    swapped = true;
                }
            } while (swapped);

            return intArray;
        }
    }
}