using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number4();
        }

        static void Number1()
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 60 };

            arr[IndexOfMin(arr)] *= 2;

            PrintArray(arr);
        }

        static void Number2()
        {
            int[] arr = { 4, 6, -1, 3, 60, -11, 5 };

            int sum = 0;
            for (int i = 0; i < IndexOfMax(arr); i++)
                sum += arr[i];

            Console.WriteLine(sum);
        }

        static void Number3()
        {
            int[] arr = { 4, 6, -1, 3, 5, -11, 60 };

            for (int i = 0; i < IndexOfMin(arr); i++)
                arr[i] *= 2;
            
            PrintArray(arr);
        }

        static void Number4()
        {
            int[] arr = { 4, 6, -1, 12, 5, -11, 2 };

            int avg = AvarageOfArray(arr);
            for (int i = IndexOfMax(arr); i < arr.Length; i++)
            {
                arr[i] = avg;
            }

            PrintArray(arr);
        }

        static int IndexOfMax(int[] arr)
        {
            int iMax = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (iMax < arr[i])
                {
                    iMax = i;
                }
            }
            return iMax;
        }

        static int IndexOfMin(int[] arr)
        {
            int iMin = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (iMin > arr[i])
                {
                    iMin = i;
                }
            }
            return iMin;
        }
        
        static int AvarageOfArray(int[] arr)
        {
            int avg = 0;
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
    }
}
