//Chapter Loops - book, Task 003
//13.12.2022, 23:52
using System;

public class MinAndMaxNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number > max)
            {
                max = number;
            }

            if(number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"Min number is: {min}");
        Console.WriteLine($"Max number is: {max}");
    }
}