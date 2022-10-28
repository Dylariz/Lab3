using System;
using System.Collections;
using System.Linq;

namespace Level2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number20();
        }
        
        static void Number1() // Минимальный элемент заданного одномерного массива увеличить в два раза.
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 13 };

            arr[IndexOfMin(arr)] *= 2;

            PrintArray(arr);
        }
        
        static void Number2() // В одномерном массиве найти сумму элементов, расположенных до максимального элемента массива.
        {
            int[] arr = { 4, 6, -1, 3, 16, -11, 5 };

            int sum = 0;
            for (int i = 0; i < IndexOfMax(arr); i++)
                sum += arr[i];

            Console.WriteLine(sum);
        }
        
        static void Number3() // Все элементы одномерного массива, расположенные перед минимальным, увеличить в 2 раза.
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 15 };

            for (int i = 0; i < IndexOfMin(arr); i++)
                arr[i] *= 2;

            PrintArray(arr);
        }
        
        static void Number4() // В одномерном массиве все элементы, расположенные после максимального, заменить средним значением элементов массива.
        {
            double[] arr = { 4, 6, -1, 12, 5, -11, 2 };

            double avg = AvarageOfArray(arr);
            for (int i = IndexOfMax(arr); i < arr.Length; i++)
            {
                arr[i] = avg;
            }

            PrintArray(arr);
        }
        
        static void Number5() // Задан одномерный массив. Сформировать другой одномерный массив из отрицательных элементов, расположенных между максимальным и минимальным элементами исходного массива.
        {
            int[] arr = { 4, 12, -1, -6, 5, -11, 2 };
            
            int indexMax = IndexOfMax(arr);
            int indexMin = IndexOfMin(arr);
            
            int indexFirst = indexMin < indexMax ? indexMin : indexMax;
            int indexLast = indexMin > indexMax ? indexMin : indexMax;
            
            int[] resultArr = new int[arr.Skip(indexFirst + 1).Take(indexLast - indexFirst - 1).Count(t => t < 0)];
            
            int index = 0;
            for (int i = indexFirst; i < indexLast; i++)
            {
                if (arr[i] < 0)
                {
                    resultArr[index] = arr[i];
                    index++;
                }
            }

            PrintArray(resultArr);
        }
        
        static void Number6() // Задан одномерный массив и число P. Включить элемент, равный Р, после того элемента массива, который наиболее близок к среднему значению его элементов.
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 14 };
            int p = 12;

            double avg = AvarageOfArray(arr);
            int indexOfReplace = IndexOfMin(arr.Select(t => Math.Abs(t - avg)).ToArray()) + 1;

            int[] resultArr = new int[arr.Length + 1];
            for (int i = 0; i < indexOfReplace; i++)
                resultArr[i] = arr[i];
            resultArr[indexOfReplace] = p;
            for (int i = indexOfReplace; i < arr.Length; i++)
                resultArr[i + 1] = arr[i];

            PrintArray(resultArr);
        }
        
        static void Number7() // Увеличить в 2 раза элемент, расположенный непосредственно после максимального элемента массива.
        {
            int[] arr = { 4, 6, -1, 13, 5, -11, 4 };

            int index = IndexOfMax(arr);
            arr[index + 1] *= 2;

            PrintArray(arr);
        }
        
        static void Number8() // Поменять местами максимальный элемент массива и минимальный элемент части массива, расположенной после максимального.
        {
            int[] arr = { 4, -22, 13, -1, 3, 5, -11, 7 };

            int indexMax = IndexOfMax(arr);
            int indexMin = IndexOfMin(arr, indexMax);

            (arr[indexMax], arr[indexMin]) = (arr[indexMin], arr[indexMax]);

            PrintArray(arr);
        }
        
        static void Number9() // Найти среднее арифметическое значение элементов массива, расположенных между минимальным и максимальным элементами массива.
        {
            int[] arr = { 4, 6, -11, 3, -4, 2, 11, 13 };

            int indexMax = IndexOfMax(arr);
            int indexMin = IndexOfMin(arr);
            
            int indexFirst = indexMin < indexMax ? indexMin : indexMax;
            int indexLast = indexMin > indexMax ? indexMin : indexMax;

            int[] partOfArr = arr.Skip(indexFirst + 1).Take(indexLast - indexFirst - 1).ToArray();

            Console.WriteLine(AvarageOfArray(partOfArr));
        }
        
        static void Number10() // Удалить минимальный среди положительных элементов массива.
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 13 };
            int indexOfMin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] < arr[indexOfMin])
                    indexOfMin = i;
            }
            
            int[] resultArr = new int[arr.Length - 1];
            
            for (int i = 0; i < indexOfMin; i++)
                resultArr[i] = arr[i];
            
            for (int i = indexOfMin; i < resultArr.Length; i++)
                resultArr[i] = arr[i + 1];

            PrintArray(resultArr);
        }
        
        static void Number11() // Включить заданный элемент P после последнего положительного элемента массива.
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 13 };
            int p = 12;
            
            int index = 0;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] > 0)
                {
                    index = i;
                    break;
                }
            }

            index++;
            int[] resultArr = new int[arr.Length + 1];

            for (int i = 0; i < index; i++)
                resultArr[i] = arr[i];
            
            resultArr[index] = p;
            
            for (int i = index; i < arr.Length; i++)
                resultArr[i + 1] = arr[i];

            PrintArray(resultArr);
        }
        
        static void Number12() // Первый отрицательный элемент массива заменить суммой элементов, расположенных после максимального.
        {
            int[] arr = { 4, 6, -1, 3, 15, -11, 14 };

            int indexMax = IndexOfMax(arr);
            int sum = 0;
            for (int i = indexMax + 1; i < arr.Length; i++)
                sum += arr[i];
            
            int indexOfFirstNegative = Array.IndexOf(arr, Array.Find(arr, t => t < 0));
            
            arr[indexOfFirstNegative] = sum;

            PrintArray(arr);
        }
        
        static void Number13() // Максимальный элемент массива среди элементов с четными индексами заменить значением его индекса.
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 13 };

            int indexMax = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0 && arr[i] > arr[indexMax])
                    indexMax = i;
            }
            
            arr[indexMax] = indexMax;
            PrintArray(arr);
        }
        
        static void Number14() // Поменять местами максимальный и первый отрицательный элементы массива.
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 13 };

            int indexMax = IndexOfMax(arr);
            int indexOfFirstNegative = Array.IndexOf(arr, Array.Find(arr, t => t < 0));
            
            (arr[indexMax], arr[indexOfFirstNegative]) = (arr[indexOfFirstNegative], arr[indexMax]);

            PrintArray(arr);
        }
        
        static void Number15() // Заданы массивы А и В, содержащие n и m элементов соответственно. Вставить массив В между k-м и (k + 1)-м элементами массива А (k задано).
        {
            int[] arrA = { 4, 6, -1, 3, 5, -11, 13 };
            int[] arrB = { 1, 2, 3, 4, 5 };
            int k = 2;

            int[] resultArr = new int[arrA.Length + arrB.Length];

            for (int i = 0; i < k; i++)
                resultArr[i] = arrA[i];
            
            for (int i = k; i < k + arrB.Length; i++)
                resultArr[i] = arrB[i - k];
            
            for (int i = k + arrB.Length; i < resultArr.Length; i++)
                resultArr[i] = arrA[i - arrB.Length];

            PrintArray(resultArr);
        }
        
        static void Number16() // Определить индексы элементов массива, меньших среднего. Результат получить в виде массива.
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 13 };
            double average = AvarageOfArray(arr);
            int[] resultArr = new int[arr.Count(t => t < average)];
            
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < average)
                {
                    resultArr[j] = i;
                    j++;
                }
            }
            PrintArray(resultArr);
        }
        
        static void Number17() // Если максимальный элемент расположен до минимального, то найти среднее арифметическое положительных элементов массива, иначе - среднее арифметическое отрицательных элементов массива.
        {
            int[] arr = { 4, -11, -1, 3, 5, 13, 5  }; // 4, -11, -1, 3, 5, 13, 5 

            int indexMax = IndexOfMax(arr);
            int indexMin = IndexOfMin(arr);
            
            double avg = AvarageOfArray(indexMax < indexMin ? arr.Where(t => t > 0).ToArray() : arr.Where(t => t < 0).ToArray());

            Console.WriteLine(avg);
        }

        static void Number18() // Если максимальный среди элементов с четными индексами больше максимального среди элементов с нечетными индексами, то заменить нулями элементы первой половины массива, иначе – элементы второй половины.
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 13, 4 }; // 4, 6, -1, 3, 5, 13, -11, 4

            int maxEven = MaxOfArray(arr.Where((t, i) => i % 2 == 0).ToArray());
            int maxOdd = MaxOfArray(arr.Where((t, i) => i % 2 != 0).ToArray());

            if (maxEven > maxOdd)
            {
                for (int i = 0; i < arr.Length / 2; i++)
                    arr[i] = 0;
            }
            else
            {
                for (int i = arr.Length / 2; i < arr.Length; i++)
                    arr[i] = 0;
            }

            PrintArray(arr);
        }
        
        static void Number19() // Если максимальный элемент массива больше суммы элементов массива, заменить его нулем, иначе – удвоить.
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 13 };

            int indexMax = IndexOfMax(arr);
            int sum = 0;
            foreach (int i in arr)
                sum += i;

            if (arr[indexMax] > sum)
                arr[indexMax] = 0;
            else
                arr[indexMax] *= 2;

            PrintArray(arr);
        }
        
        static void Number20() // Если 1-й отрицательный элемент массива расположен до минимального, то найти сумму элементов с четными индексами, иначе - с нечетными индексами .
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 13 }; // 4, 6, -11, 3, 5, -1, 13 

            int indexFirstNegative = Array.IndexOf(arr, Array.Find(arr, t => t < 0));
            int indexMin = IndexOfMin(arr);

            int sum = 0;
            if (indexFirstNegative < indexMin)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (i % 2 == 0)
                        sum += arr[i];
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                    if (i % 2 != 0)
                        sum += arr[i];
            }

            Console.WriteLine(sum);
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

        static int MinOfArray(int[] arr)
        {
            int min = arr[0];
            foreach (int i in arr)
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

        static void PrintArray(Array arr)
        {
            IEnumerator enumerator = arr.GetEnumerator();
            while (enumerator.MoveNext())
                Console.Write($"{enumerator.Current} ");
        }

        #endregion
    }
}