namespace Classes
{
    internal class Program

{
    private static void Main(string[] args)
    {
            CustomerManager customerManager = new CustomerManager();
            customerManager.add();
            customerManager.update();

            ProductManager productManager = new ProductManager();
            productManager.add();
            productManager.update();

            Customer customer = new Customer();
            customer.City = "Bursa";
            customer.Id = 1;
            customer.FirstName = "Fatih";
            customer.LastName = "Demirağ";

            Customer customer2 = new Customer
            {
                City = "Bursa", FirstName = "Fatih", Id = 1,LastName="Demirağ"
            };

            Console.WriteLine(customer.LastName);


            Console.ReadLine();

    }

}




}

