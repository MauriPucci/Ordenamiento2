using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 1, 4, 3, 2 };
            int[] array2 = { 5, 1, 4, 3, 2 };

            int[] array3 = { 1, 2, 12, 6, 3, 4, 9, 11, 5, 8, 7, 10, 13, 15, 14 };
            int[] array4 = { 1, 2, 12, 6, 3, 4, 9, 11, 5, 8, 7, 10, 13, 15, 14 };

            Console.WriteLine("Bubble Sort:");
            BubbleSort(array1);
            PrintArray(array1);

            Console.WriteLine("Selection Sort:");
            SelectionSort(array2);
            PrintArray(array2);

            Console.WriteLine($"Bubble Sort Steps: {BubbleSortSteps}");
            Console.WriteLine($"Selection Sort Steps: {SelectionSortSteps}");

            Console.WriteLine("Bubble Sort con el segundo array:");
            BubbleSort(array3);
            PrintArray(array3);

            Console.WriteLine("Selection Sort con el segundo array:");
            SelectionSort(array4);
            PrintArray(array4);

            Console.WriteLine($"Bubble Sort Steps (Large Array): {BubbleSortSteps}");
            Console.WriteLine($"Selection Sort Steps (Large Array): {SelectionSortSteps}");
        }

        static long BubbleSortSteps;
        static long SelectionSortSteps;

        static void BubbleSort(int[] array)
        {
            BubbleSortSteps = 0;
            int n = array.Length;
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    BubbleSortSteps++;
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                PrintArray(array);
            }

            stopwatch.Stop();
            Console.WriteLine($"Bubble Sort Time: {stopwatch.ElapsedTicks} ticks");
        }

        static void SelectionSort(int[] array)
        {
            SelectionSortSteps = 0;
            int n = array.Length;
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    SelectionSortSteps++;
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
                PrintArray(array);
            }

            stopwatch.Stop();
            Console.WriteLine($"Selection Sort Time: {stopwatch.ElapsedTicks} ticks");
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
