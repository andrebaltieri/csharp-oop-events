using System;
using BaltaDemo.Entities;

namespace BaltaDemo.Events
{
    public class CustomerCreatedEventHandler : Customer
    {
        public CustomerCreatedEventHandler(string name, string email)
        {
            var evt = new OnCustomerCreatedEvent(Handle);
            evt(name, email);
        }

        protected void Handle(string name, string email)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Evento: Cliente criado");
            Console.WriteLine(name);
            Console.WriteLine(email);
            Console.WriteLine("------------------------");
        }
    }
}
