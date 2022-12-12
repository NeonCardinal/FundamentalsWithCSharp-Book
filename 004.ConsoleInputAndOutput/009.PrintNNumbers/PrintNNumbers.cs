//Chapter Console input and output - book, Task 010
//11.12.2022, 01:54
using System;

public class PrintNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}