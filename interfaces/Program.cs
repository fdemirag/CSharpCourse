using interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        // InterfacesIntro();
        //Demo();
        ICustomerDal[] customerDals = new ICustomerDal[3]
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            new MySqlServerCustomerDal()
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }

        Console.ReadLine();


    }

    private static void Demo()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager manager = new PersonManager();
        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "Fatih",
            SecondName = "Demirağ",
            Adress = "Bursa"
        };
        Student student = new Student
        {
            Id = 2,
            FirstName = "Fatih",
            SecondName = "Demirağ",
            Deparmant = "Yazilimci Adayi"
        };
        manager.add(customer);
        manager.add(student);
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string SecondName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }


        public string Deparmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }


        public string Deparmant { get; set; }
    }

    class PersonManager
    {
        public void add(IPerson person)
        {
            Console.WriteLine(person.SecondName);
        }
    }
}