using System.Collections.Generic;

namespace Practice_Case_Study___II
{
    public class NotificationService : INotificationService
    {
        private List<INotificationObserver> _observers = new List<INotificationObserver>();
        public void AddSubscriber(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObserver()
        {
            foreach(var observer in _observers)
            {
                observer.OnServerDown();
            }
        }

        public void RemoveSubscriber(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
