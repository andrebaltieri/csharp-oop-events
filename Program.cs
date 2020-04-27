using System;
using BaltaDemo.Entities;
using BaltaDemo.Events;
using BaltaDemo.ValueObjects;

namespace BaltaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new Name("André", "Baltieri");
            var email = new Email("andre@balta.io");
            var customer = new Customer(name, email);

            var handler = new CustomerCreatedEventHandler(name?.ToString(), email?.ToString());
        }
    }
}
