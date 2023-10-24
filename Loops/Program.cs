internal class Program
{
    private static void Main(string[] args)
    {
        int number = 100;
        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }

         Console.ReadLine();
    }

    private static void ForLoop()
    {
        for (int i = 100; i >= 0; i = i - 2)
        {
            Console.WriteLine(i);

        }
    }
}