internal class Program
{
    private static void Main(string[] args)
    {
        String city = "Ankara";
        //Console.WriteLine(city[4]);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }

        String city2 = "İstanbul";

        Console.WriteLine(String.Format("{0} {1}" ,city,city2));

        Console.ReadLine();
    }
    
}