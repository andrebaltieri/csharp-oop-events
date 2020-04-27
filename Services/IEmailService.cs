using System;

namespace BaltaDemo.Services
{
    public interface IEmailService
    {
        void Send(string name, string email, string subject, string body);
    }
}
