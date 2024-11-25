using System;

public class ArraySorter
{
    // Метод сортировки массива по возрастанию (без использования LINQ)
    public static void SortAscending(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Метод сортировки массива по убыванию (без использования LINQ)
    public static void SortDescending(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Метод объединения двух массивов в один
    public static int[] ConcatenateArrays(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];
        Array.Copy(arr1, result, arr1.Length);
        Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
        return result;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 5, 2, 8, 1, 9, 4 };
        Console.WriteLine("Исходный массив: " + string.Join(", ", arr));

        SortAscending(arr);
        Console.WriteLine("Отсортированный по возрастанию: " + string.Join(", ", arr));

        SortDescending(arr);
        Console.WriteLine("Отсортированный по убыванию: " + string.Join(", ", arr));


        int[] arr2 = { 10, 3, 7, 6 };
        int[] mergedArr = ConcatenateArrays(arr, arr2);
        Console.WriteLine("Объединенный массив: " + string.Join(", ", mergedArr));
    }
}

