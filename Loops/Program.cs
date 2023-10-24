﻿internal class Program
{
    private static void Main(string[] args)
    {
        string[] students = new string[3] { "Engin", "Derin", "Salih" };

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }


        Console.ReadLine();
    }

    private static void DoWhileLoop()
    {
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;
        }
        while (number >= 1);
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