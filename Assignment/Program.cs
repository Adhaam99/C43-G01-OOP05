
using Rectangle = Assignment.Classes.Rectangle;

using Circle = Assignment.Classes.Circle;
using Assignment.Interfaces;
using static System.Net.Mime.MediaTypeNames;
using Assignment.Classes;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 - Define an interface named IShape with a property Area and a method DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inheritfrom IShape.Implement these interfaces in classes Circle and Rectangle. Testyour implementation by creating instances of both classes and displaying theirshape information.

            //IRectangle R = new Rectangle();

            //R.Area = 10;

            //R.DisplayShapeInfo();

            //ICircle Circle = new Circle();

            //Circle.Area = 25;

            //Circle.DisplayShapeInfo();

            #endregion

            #region Q2

            //IAuthenticationService User01 = new BasicAuthenticationService("Adham", "0123456", "admin");

            //Console.WriteLine(User01.AuthenticateUser("Adham", "0123456"));

            //Console.WriteLine(User01.AuthorizeUser("Adham", "admin"));

            #endregion

            #region Q3

            INotificationService email = new EmailNotificationService();

            email.SendNotification("Khaled", "How are you?");

            INotificationService SMS = new SmsNotificationService();

            SMS.SendNotification("Adham", "I'm fine , thanks");

            INotificationService notification = new PushNotificationService();

            notification.SendNotification("Khaled", "New message from 'Adham' ");

            #endregion

        }
    }
}
