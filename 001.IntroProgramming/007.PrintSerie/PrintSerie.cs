//Chapter Intro programming, Task 010
//18.11.2022, 00:59
using System;
using System.Collections.Concurrent;

public class PrintSerie
{
    static void Main()
    {
        for(int i = 2; i <= 102; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine($"{i}");
            }
            else
            {
                Console.WriteLine($"-{i}");
            }
        }
    }
}