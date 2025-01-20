using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Interfaces;

namespace Assignment.Classes
{
    class SmsNotificationService : INotificationService
    {
        public void SendNotification(string? recipient, string? message)
        {
            Console.WriteLine($"This SMS to {recipient}\nMessage : {message}");
        }
    }
}
