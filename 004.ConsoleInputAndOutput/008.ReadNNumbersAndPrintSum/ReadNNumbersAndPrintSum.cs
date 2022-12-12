//Chapter Console input and output - book, Task 009
//11.12.2022, 01:45
using System;

public class ReadNNumbersAndPrintSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            sum += number;
        }

        Console.WriteLine(sum);
    }
}