internal class Program
{
    private static void Main(string[] args)
    {

    }
    interface IPerson
    {
        int Id { get; set; }
        int FirstName { get; set; }
        int SecondName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get ; set ; }
        public int FirstName { get; set; }
        public int SecondName { get; set; }

        public string Adress { get; set; }
    }
    class Student:IPerson
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int SecondName { get; set; }


        public string Deparmant { get; set; }
    }
}