internal class Program
{
    private static void Main(string[] args)
    {
        Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName="Fatih"
                },
                new Student
                {
                    FirstName="Mehmet"
                },
                new Person
                {
                    FirstName="asd"
                }
            };
        foreach (var person in persons)
        {
            Console.WriteLine(person.FirstName);
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set;}
    }
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Department { get; set; }
    }
}
    