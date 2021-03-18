using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Case_Study___II
{
    class Program
    {
        static void Main(string[] args)
        {
            JohnObserver john = new JohnObserver() { Name = "John" };
            SteveObserver steve = new SteveObserver() { Name = "Steve" };

            NotificationService notyService = new NotificationService();
            notyService.AddSubscriber(john);
            notyService.AddSubscriber(steve);

            notyService.NotifyObserver();
            notyService.RemoveSubscriber(john);

            Console.Read();
        }
    }
}
