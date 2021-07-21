using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {

        public void Add (Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " isimli kullanıcı bankaya eklenmiştir.");
        }

        public void List (Customer customer)
        {
            Console.WriteLine("Bankamızın aktif müşteri listesi : " + customer.Name);
        }

        public void Delete (Customer customer)
        {
            Console.WriteLine("Bankamızdan ayrılan müşterimiz : " + customer.Name);
        }

    }
}
