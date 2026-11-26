// Insertion Sort
// Time Complexity:  Best O(n) (when already sorted) | Average O(n^2) | Worst O(n^2)
// Space Complexity: O(1) auxiliary space
// Stable: Yes

using System;

public class InsertionSort
{
    public static void Sort(int[] numbers, Func<int, int, bool> compare)
    {
        for (int j = 1; j < numbers.Length; j++)
        {
            int key = numbers[j], i = j - 1;
            while (i >= 0 && compare(key, numbers[i]))
            {
                numbers[i + 1] = numbers[i];
                i--;
            }
            numbers[i + 1] = key;
        }
    }

    public static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(new string('=', 100));
        int[] numbers = { 5, 2, 3, 6, 7, 1 };
        Console.WriteLine(string.Join(',', numbers));

        Console.WriteLine("Insertion Sort");
        Sort(numbers, (a, b) => a < b);
        Console.WriteLine(string.Join(',', numbers));
        Sort(numbers, (a, b) => a > b);
        Console.WriteLine(string.Join(',', numbers));

        Console.WriteLine(new string('=', 100));
        Console.ResetColor();
    }
}
