//Chapter Loops - book, Task 002
//13.12.2022, 23:50
using System;

public class PrintNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            if(i % 3 != 0 && i % 7 != 0)
                Console.WriteLine(i);
        }
    }
}