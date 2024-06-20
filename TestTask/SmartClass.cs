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
        /// Суммирует два числа, проверяя сумму на переполнение.
        /// </summary>
        private int? CheckedSumElements(int firstElement,int secondElement)
        {
            try
            {
                return checked(firstElement + secondElement);
            }
            catch (OverflowException)
            {
                // Предположим, что в случае переполнения мы должны вывести сообщение об ошибке и вернуть null
                Console.WriteLine($"Результат суммы двух минимальных элементов массива ({firstElement}, {secondElement}) превысил допустимые значения возвращаемого типа.");
                return null;
            }
        }
        /// <summary>
        /// Возвращает сумму двух минимальных элементов массива чисел.
        /// </summary>
        public int? SumTwoMinElements(int[] arr)
        {
            if (arr is null) return null;
            int length = arr.Length;
            if (length <= 1) return null; // Предположим, что при длине массива меньше 2, функция должна возвращать null
            if (length == 2) return this.CheckedSumElements( arr[0] , arr[1]);

            int minFirstElement;
            int minSecondElement;
            if (arr[0] < arr[1])
            {
                minFirstElement = arr[0];
                minSecondElement = arr[1];
            }
            else
            {
                minFirstElement = arr[1];
                minSecondElement = arr[0];
            }
            for (int i = 2; i < arr.Length; i++)
            {

                if (arr[i] < minFirstElement)
                {
                    minSecondElement = minFirstElement;
                    minFirstElement = arr[i];
                    continue;
                }
                if (arr[i] < minSecondElement)
                    minSecondElement = arr[i];
            }
            return CheckedSumElements(minFirstElement, minSecondElement);
        }
    }
}
