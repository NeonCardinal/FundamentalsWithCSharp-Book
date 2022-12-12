//Chapter Contitional statements - book, Task 002
//13.12.2022, 00:14
using System;

public class PrintSign
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int cnt = 0;

        if(a < 0)
        {
            cnt++;
        }
        else
        {
            cnt--;
        }
        if(b < 0)
        {
            cnt++;
        }
        else
        {
            cnt--;
        }
        if(c < 0)
        {
            cnt++;
        }
        else
        {
            cnt--;
        }

        if(cnt % 2 == 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}