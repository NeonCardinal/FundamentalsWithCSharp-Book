//Chapter Console input and output - book, Task 005
//11.12.2022, 01:31
using System;

public class PrintNumbers
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for(int i = start; i <= end; i++)
        {
            if(i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}