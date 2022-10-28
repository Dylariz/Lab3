using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number1();
        }
        
        static void Number1() // Найти сумму элементов одномерного массива размера 6. Разделить каждый элемент исходного массива на полученное значение. Результат получить в том же массиве.
        {
            double[] array = { 1, 2, 3, 4, 5, 6 };
            double sum = SumOfArray(array);
            
            for (int i = 0; i < array.Length; i++)
                array[i] /= sum;
            PrintArray(array);
        }
        static void Number2() // Положительные элементы массива размера 8 заменить средним арифметическим среди положительных элементов.
        {
            double[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double average = AvarageOfArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    array[i] = average;
            }
            PrintArray(array);
        }
        static void Number3() // Вычислить сумму и разность двух одномерных массивов размера 4. (Суммой (разностью) двух массивов одинакового размера называется третий массив такого же размера, каждый элемент которого равен сумме (разности) соответствующих элементов исходных массивов.)
        {
            double[] array1 = { 1, 2, 3, 4 };
            double[] array2 = { 5, 6, 7, 8 };
            double[] array3 = new double[4];
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
            }
            PrintArray(array3);
            
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] - array2[i];
            }
            PrintArray(array3);
        }
        static void Number4() // Найти среднее значение элементов массива размера 5. Преобразовать исходный массив, вычитая из каждого элемента полученное значение.
        {
            double[] array = { 1, 2, 3, 4, 5 };
            double average = AvarageOfArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= average;
            }
            PrintArray(array);
        }
        static void Number5() // Вычислить скалярное произведение двух векторов размера 4. (Скалярным произведением называется сумма попарных произведений соответствующих элементов массивов.)
        {
            double[] array1 = { 1, 2, 3, 4 };
            double[] array2 = { 5, 6, 7, 8 };
            double sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i] * array2[i];
            }
            Console.WriteLine($"Скалярное произведение: {sum}");
        }
        static void Number6() // Вычислить длину вектора размера 5. (Длина вектора равна квадратному корню из суммы квадратов его элементов.)
        {
            double[] array = { 1, 2, 3, 4, 5 };
            double sum = 0;
            foreach (var t in array)
            {
                sum += Math.Pow(t, 2);
            }
            Console.WriteLine($"Длина вектора: {Math.Sqrt(sum)}");
        }
        static void Number7() // Элементы одномерного массива размера 7, большие среднего значения элементов массива, заменить на 0.
        {
            double[] array = { 1, 2, 3, 4, 5, 6, 7 };
            double average = AvarageOfArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > average)
                    array[i] = 0;
            }
            PrintArray(array);
        }
        static void Number8() // Подсчитать количество отрицательных элементов заданного одномерного массива размера 6.
        {
            double[] array = { 1, 2, 3, 4, 5, 6 };
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    count++;
            }
            Console.WriteLine($"Количество отрицательных элементов: {count}");
        }
        static void Number9() // Определить, сколько элементов заданного одномерного массива размера 8 больше среднего значения элементов этого массива.
        {
            double[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double average = AvarageOfArray(array);
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > average)
                    count++;
            }
            Console.WriteLine($"Количество элементов больше среднего значения: {count}");
        }
        static void Number10() // Дан одномерный массив размера 10 и два числа P и Q (P < Q). Определить, сколько элементов массива заключено между P и Q.
        {
            double[] array = { 6, 5, 3, 4, 5, 6, 7, 8, 9, 10 };
            int p = 3;
            int q = 7;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > p && array[i] < q)
                    count++;
            }
            Console.WriteLine($"Количество элементов между P и Q: {count}");
        }
        static void Number11() // Сформировать массив из положительных элементов заданного массива размера 10.
        {
            double[] array = { 1, -2, 3, -4, -5, 6, 7, -8, -9, 10 };
            double[] array2 = new double[array.Length];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array2[j] = array[i];
                    j++;
                }
            }
            PrintArray(array2);
        }
        static void Number12() // Определить значение и номер последнего отрицательного элемента массива размера 8.
        {
            double[] array = { 1, 2, -3, 4, -5, 6, 7, -8 };
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    index = i;
            }
            Console.WriteLine($"Значение последнего отрицательного элемента: {array[index]}");
            Console.WriteLine($"Номер последнего отрицательного элемента: {index}");
        }
        static void Number13() // Дан массив размера 10. Сформировать два массива размера 5, включая в первый массив элементы исходного массива с четными индексами, во второй – с нечетными.
        {
            double[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] array2 = new double[array.Length / 2];
            double[] array3 = new double[array.Length / 2];
            int j = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array2[j] = array[i];
                    j++;
                }
                else
                {
                    array3[k] = array[i];
                    k++;
                }
            }
            PrintArray(array2);
            PrintArray(array3);
        }
        static void Number14() // Найти сумму квадратов элементов, расположенных до первого отрицательного элемента массива размера 11.
        {
            double[] array = { 1, 2, 3, 4, 5, -6, 7, -8, 9, 10, 11 };
            int index = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            for (int i = 0; i < index; i++)
            {
                sum += Math.Pow(array[i], 2);
            }
            Console.WriteLine($"Сумма квадратов элементов до первого отрицательного элемента: {sum}");
        }
        static void Number15() // Задан массив х размера 10. Вычислить значения функции у = 0,5lnx при значениях аргумента, заданных в массиве х. Вычисленные значения поместить в массив y. Вывести массивы х и y в виде двух столбцов.
        {
            double[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] array2 = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = 0.5 * Math.Log(array[i]);
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"x = {array[i]}; y = {array2[i]}");
            }
        }

        #region FunctionalMethods
        static int MaxOfArray(int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr)
                if (i > max)
                    max = i;
            return max;
        }
        static double MaxOfArray(double[] arr)
        {
            double max = arr[0];
            foreach (double i in arr)
                if (i > max)
                    max = i;
            return max;
        }
        static int MinOfArray(int[] arr)
        {
            int min = arr[0];
            foreach (int i in arr)
                if (i < min)
                    min = i;
            return min;
        }
        static double MinOfArray(double[] arr)
        {
            double min = arr[0];
            foreach (double i in arr)
                if (i < min)
                    min = i;
            return min;
        }
        static int IndexOfMax(int[] arr, int startIndex = 0)
        {
            int iMax = startIndex;
            for (int i = startIndex + 1; i < arr.Length; i++)
            {
                if (arr[iMax] < arr[i])
                {
                    iMax = i;
                }
            }

            return iMax;
        }
        static int IndexOfMax(double[] arr, int startIndex = 0)
        {
            int iMax = startIndex;
            for (int i = startIndex + 1; i < arr.Length; i++)
            {
                if (arr[iMax] < arr[i])
                {
                    iMax = i;
                }
            }

            return iMax;
        }
        static int IndexOfMin(int[] arr, int startIndex = 0)
        {
            int iMin = startIndex;
            for (int i = startIndex + 1; i < arr.Length; i++)
            {
                if (arr[iMin] > arr[i])
                {
                    iMin = i;
                }
            }

            return iMin;
        }
        static int IndexOfMin(double[] arr, int startIndex = 0)
        {
            int iMin = startIndex;
            for (int i = startIndex + 1; i < arr.Length; i++)
            {
                if (arr[iMin] > arr[i])
                {
                    iMin = i;
                }
            }

            return iMin;
        }
        static double AvarageOfArray(int[] arr)
        {
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }

            return avg / arr.Length;
        }
        static double AvarageOfArray(double[] arr)
        {
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }

            return avg / arr.Length;
        }
        static int SumOfArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
        static double SumOfArray(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
        static void BubleSort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }
        static void BubleSort(ref double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }
        static void PrintArray(Array arr)
        {
            IEnumerator enumerator = arr.GetEnumerator();
            while (enumerator.MoveNext())
                Console.Write($"{enumerator.Current} ");
        }
        #endregion
    }
}
