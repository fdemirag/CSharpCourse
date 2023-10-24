internal class Program
{
    private static void Main(string[] args)
    {
        if (IsPrimeNumber(6))
        {
            Console.WriteLine("this is a prime number");
        }
        else
        {
            Console.WriteLine("this is not a prime number");
        }
        



        Console.ReadLine();
    }

    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number-1; i++)
        {
            if (number%i==0)
            {
                result = false;
                i = number;
            }
        }
        return result;
    }


    private static void ForeachLoop()
    {
        string[] students = new string[3] { "Engin", "Derin", "Salih" };

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
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