using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Level3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number5();
        }
        
        static void Number5() // Упорядочить по возрастанию элементы массива с четными индексами (остальные элементы оставить на своих местах).
        {
            int[] arr = InputArray(); // { 4, 6, -1, 3, 13, -11, 2, 1, 43, -2, -7, 5 };
            
            int[] arr2 = new int[(int)Math.Ceiling(arr.Length / 2.0)];
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arr2[i/2] = arr[i];
                }
            }
            BubleSort(ref arr2);
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = arr2[i/2];
                }
            }
            
            PrintArray(arr);
        }
        static void Number8() // Упорядочить по убыванию отрицательные элементы массива, сохраняя остальные элементы на прежних местах.
        {
            int[] arr = InputArray(); // { 4, 6, -1, 3, 13, -11, 2, 1, 43, -2, -7, 5 };
            
            int[] arr2 = new int[arr.Count(t => t < 0)];

            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr2[j] = arr[i];
                    j++;
                }
            }
            BubleSort(ref arr2);
            
            j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr2[j];
                    j++;
                }
            }
            
            PrintArray(arr);
        }
        
        #region FunctionalMethods
        static int IndexOfFirst<T>(IEnumerable<T> arr, T value)
        {
            int index = 0;
            foreach (T i in arr)
            {
                if (i.Equals(value))
                    return index;
                index++;
            }
            return -1;
        }
        static T FindFirstValue<T>(IEnumerable<T> arr, Predicate<T> predicate)
        {
            foreach (var i in arr)
                if (predicate(i))
                    return i;
            return default(T);
        }
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
        static int[] InputArray()
        {
            Console.Write("Введите размер массива: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
                Console.Write("Неверный ввод!\nВведите размер массива: ");

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите {i + 1}-й элемент массива: ");
                if (int.TryParse(Console.ReadLine(), out arr[i])) continue;
                
                i--;
            }

            return arr;
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
