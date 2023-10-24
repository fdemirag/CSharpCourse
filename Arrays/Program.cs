internal class Program
{
    private static void Main(string[] args)
    {
        //string[] students = new string[3];
        //students[0] = "Engin";
        //students[1] = "Derin";
        //students[2] = "Salih";

        //string[] students = new string[3] { "Engin", "Derin", "Salih" };

        //string[] students2 = { "Engin", "Derin", "Salih" };

        //foreach (var student in students2)
        //{
        //    Console.WriteLine(student);
        //}

        string[,] region = new string[5, 3]
        {
            {"İstanbul","İzmit","Balıkesir"},
            {"Ankara","Konya","Kırıkkale"},
            {"Antalya","Adana","Mersin"},
            {"Rize","Trabzon","Samsun"},
            {"İzmir","Muğla","Manisa"}
        };
        for (int i = 0; i <= region.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= region.GetUpperBound(1); j++)
            {
                Console.WriteLine(region[i,j]);
            }
        }


        Console.Read();

    }
}