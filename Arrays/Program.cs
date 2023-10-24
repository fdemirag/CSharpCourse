internal class Program
{
    private static void Main(string[] args)
    {
        //string[] students = new string[3];
        //students[0] = "Engin";
        //students[1] = "Derin";
        //students[2] = "Salih";

        string[] students = new string[3] { "Engin", "Derin", "Salih" };

        string[] students2 = { "Engin", "Derin", "Salih" };

        foreach (var student in students2)
        {
            Console.WriteLine(student);
        }
        Console.Read();
    }
}