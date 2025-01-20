using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Interfaces;

namespace Assignment.Classes
{
    class EmailNotificationService : INotificationService
    {
        public void SendNotification(string? recipient, string? message)
        {
            Console.WriteLine($"This email to {recipient}\nMessage : {message}");
        }
    }
}
