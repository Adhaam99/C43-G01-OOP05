using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Interfaces;

namespace Assignment.Classes
{
    class PushNotificationService : INotificationService
    {
        public void SendNotification(string? recipient , string? message)
        {
            Console.WriteLine($"Notification to {recipient}\nMessage : {message}");
        }
    }
}
