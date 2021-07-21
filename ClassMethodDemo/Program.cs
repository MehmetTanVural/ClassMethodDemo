using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Id = "123456";
            customer1.Name = "Umut";
            customer1.Surname = "Güneş";
            customer1.Age = 19;
            customer1.City = "Adana";

            Customer customer2 = new Customer();
            customer2.Id = "654321";
            customer2.Name = "Melisa";
            customer2.Surname = "Bilgin";
            customer2.Age = 25;
            customer2.City = "İstanbul";


            Customer customer3 = new Customer();
            customer3.Id = "492314";
            customer3.Name = "Deniz";
            customer3.Surname = "Vural";
            customer3.Age = 58;
            customer3.City = "İzmir";

            Customer[] customers = new Customer[] { customer1 , customer2, customer3 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname + " aktif banka müşteri listesini oluşturmaktadır.");
            }

            Console.WriteLine("----------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
            customerManager.Delete(customer3);

            












        }
    }
}
