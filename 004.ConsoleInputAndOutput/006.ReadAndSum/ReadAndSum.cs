//Chapter Console input and output - book, Task 007
//11.12.2022, 01:37
using System;

public class ReadAndSum
{
    static void Main()
    {
        int sum = 0;
        int number;

        for(int i = 0; i < 5; i++)
        {
            if(int.TryParse(Console.ReadLine(), out number) != true)
            {
                Console.WriteLine("Wrong value! Try again!");
                i--;
            }
            else
            {
                sum += number;
            }
        }

        Console.WriteLine(sum);
    }
}