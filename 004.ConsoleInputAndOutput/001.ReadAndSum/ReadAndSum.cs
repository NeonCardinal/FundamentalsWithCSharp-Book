//Chapter Console input and output - book, Task 001
//11.12.2022, 01:15
using System;

public class ReadAndSum
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int sum = a + b + c;

        Console.WriteLine(sum);
    }
}