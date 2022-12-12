//Chapter Console input and output - book, Task 008
//11.12.2022, 01:42
using System;

public class GreaterBetweenFiveNumbers
{
    static void Main()
    {
        int greater = int.MinValue;

        for(int i = 0; i < 5; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number >= greater)
            {
                greater = number;
            }
        }

        Console.WriteLine(greater);
    }
}