//Chapter Console input and output - book, Task 011
//11.12.2022, 02:26
using System;

public class PhibonachiSerie
{
    static void Main()
    {
        long fibb = 0;
        long a = 0;
        long b = 1;

        for(int i = 1; i <= 100; i++)
        {
            fibb = a + b;
            a = b;
            b = fibb;
            Console.WriteLine(fibb);
        }
    }
}