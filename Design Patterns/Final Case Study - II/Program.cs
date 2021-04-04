using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Case_Study___II
{
    public interface INotificationObserver
    {
        void OnHundredTicketBooked();
    }
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver observer);

        void RemoveSubsriber(INotificationObserver observer);

        void NotifySubscriber();
    }
    public class NotificationService : INotificationService
    {
        private List<INotificationObserver> _observers = new List<INotificationObserver>();
        private int _ticket;
        private int Ticket { get { return _ticket; } set { 
                if (value >= 100)
                {
                    NotifySubscriber();
                }
                _ticket = value;
            } }

        public void AddTicket(int num)
        {
            Ticket += num;
        }

        public void AddSubscriber(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveSubsriber(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifySubscriber()
        {
            foreach (var observer in _observers)
            {
                observer.OnHundredTicketBooked();
            }
        }
    }
    public class AdminObserver : INotificationObserver
    {
        private string _name;

        public AdminObserver(string name)
        {
            _name = name;
        }

        public void OnHundredTicketBooked()
        {
            Console.WriteLine($"{_name} -  100 tickets have been booked");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var admin = new AdminObserver("Souvik");

            var service = new NotificationService();

            service.AddSubscriber(admin);

            service.AddTicket(80);
            service.AddTicket(10);

            Console.Read();
        }
    }
}
