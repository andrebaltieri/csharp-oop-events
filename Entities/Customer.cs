using BaltaDemo.ValueObjects;

namespace BaltaDemo.Entities
{
    public class Customer : Entity
    {
        protected Customer() { }

        public Customer(Name name, Email email)
        {
            Name = name;
            Email = email;
        }

        // Propriedades
        public Name Name { get; private set; }
        public Email Email { get; private set; }

        // Métodos
        public void UpdateInfo(Name name, Email email)
        {
            Name = name;
            Email = email;
        }

        // Eventos
        public delegate void OnCustomerCreatedEvent(string name, string email);
        public delegate void OnCustomerUpdatedEvent(string name, string email);
    }
}
