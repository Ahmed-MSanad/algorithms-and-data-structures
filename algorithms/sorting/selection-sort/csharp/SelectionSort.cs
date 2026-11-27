// Selection Sort
// Time Complexity:  Best O(n^2) (Even if the array is already sorted) | Average O(n^2) | Worst O(n^2)
// Space Complexity: O(1)
// Stable: No (unstable with standard swapping)

using System;

public class SelectionSort
{
    public static void Sort(int[] numbers, Func<int, int, bool> compare)
    {
        for (int j = 0; j < numbers.Length - 1; j++)
        {
            int i = j + 1, keyIndex = j;
            while (i < numbers.Length)
            {
                keyIndex = compare(numbers[i], numbers[keyIndex]) ? i : keyIndex;
                i++;
            }
            if (keyIndex != j)
            {
                int temp = numbers[j];
                numbers[j] = numbers[keyIndex];
                numbers[keyIndex] = temp;
            }
        }
    }

    public static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(new string('=', 100));
        int[] numbers = { 5, 2, 3, 6, 7, 1 };
        Console.WriteLine(string.Join(',', numbers));

        Console.WriteLine("Selection Sort");
        Sort(numbers, (a, b) => a < b);
        Console.WriteLine(string.Join(',', numbers));
        Sort(numbers, (a, b) => a > b);
        Console.WriteLine(string.Join(',', numbers));

        Console.WriteLine(new string('=', 100));
        Console.ResetColor();
    }
}