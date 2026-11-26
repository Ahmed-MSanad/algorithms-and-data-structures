// Bubble Sort
// Time Complexity:  Best O(n) (when already sorted) | Average O(n^2) | Worst O(n^2)
// Space Complexity: O(1) auxiliary space
// Stable: Yes

using System;

public static class BubbleSort
{
    public static void Sort(int[] numbers, Func<int, int, bool> compare)
    {
        for (int j = 0; j < numbers.Length - 1; j++)
        {
            bool swapped = false;
            for (int i = 0; i < numbers.Length - 1 - j; i++) // Loops to numbers.Length - 1 - j as after each outer loop, a number whether the smallest/biggest will get at the end of the array.
            {
                if (compare(numbers[i + 1], numbers[i]))
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break; // Optimization(2): If not even a swap happens in the inner loop then the array is already got sorted.
        }
    }

    public static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(new string('=', 100));
        int[] numbers = { 5, 2, 3, 6, 7, 1 };
        Console.WriteLine(string.Join(',', numbers));

        Console.WriteLine("Bubble Sort");
        Sort(numbers, (a, b) => a < b);
        Console.WriteLine(string.Join(',', numbers));
        Sort(numbers, (a, b) => a > b);
        Console.WriteLine(string.Join(',', numbers));

        Console.WriteLine(new string('=', 100));
        Console.ResetColor();
    }
}