using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class SmartClass
    {
        /// <summary>
        /// Возвращает сумму двух минимальных элементов массива чисел.
        /// </summary>
        public int? SumTwoMinElements(int[] arr)
        {
            if (arr is null) return null;
            int length = arr.Length;
            if (length <= 1) return null; // Предположим, что при длине массива меньше 2, функция должна возвращать null
            if (length == 2) return arr[0] + arr[1];

            int minElementFirst;
            int minElementSecond;
            if (arr[0] < arr[1])
            {
                minElementFirst = arr[0];
                minElementSecond = arr[1];
            }
            else
            {
                minElementFirst = arr[1];
                minElementSecond = arr[0];
            }
            for (int i = 2; i < arr.Length; i++)
            {

                if (arr[i] < minElementFirst)
                {
                    minElementSecond = minElementFirst;
                    minElementFirst = arr[i];
                    continue;
                }
                if (arr[i] < minElementSecond)
                    minElementSecond = arr[i];
            }
            return minElementFirst + minElementSecond;
        }
    }
}
