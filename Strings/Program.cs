internal class Program
{
    private static void Main(string[] args)
    {

        string sentence = "My name is Fatih Demirağ";
        var result = sentence.Length;
        var result2 = sentence.Clone();
        sentence = "My name is Mr Demirağ";
        var result3 = sentence.EndsWith("ğ");
        var result4 = sentence.StartsWith("My name");
        var result5 = sentence.IndexOf("namee");
        var result6 = sentence.IndexOf("name");
        var result7 = sentence.LastIndexOf(" ");
        var result8 = sentence.Insert(0, "Hello, ");
        var result9 = sentence.Substring(3, 4);
        var result10 = sentence.ToLower();
        var result11 = sentence.ToUpper();
        var result12 = sentence.Replace(" ", "-");
        var result13 = sentence.Remove(2, 5);
        Console.WriteLine(result11);
        Console.ReadLine();


        Console.ReadLine();
    }

    private static void Intro()
    {
        string city = "Ankara";
        //Console.WriteLine(city[4]);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }

        String city2 = "İstanbul";

        Console.WriteLine(String.Format("{0} {1}", city, city2));
    }
}