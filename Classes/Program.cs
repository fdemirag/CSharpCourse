﻿namespace Classes
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

      
        Console.ReadLine();

    }

}




}

