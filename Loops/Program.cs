﻿internal class Program
{
    private static void Main(string[] args)
    {
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;
        }
        while (number >= 1);


        Console.ReadLine();
    }

    private static void WhileLoop()
    {
        int number = 100;
        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }
    }

    private static void ForLoop()
    {
        for (int i = 100; i >= 0; i = i - 2)
        {
            Console.WriteLine(i);

        }
    }
}