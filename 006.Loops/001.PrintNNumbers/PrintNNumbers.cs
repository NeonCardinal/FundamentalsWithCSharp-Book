//Chapter Loops - book, Task 001
//13.12.2022, 23:47
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