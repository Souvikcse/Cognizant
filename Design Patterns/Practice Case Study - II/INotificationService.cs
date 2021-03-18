namespace Practice_Case_Study___II
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver observer);
        void RemoveSubscriber(INotificationObserver observer);
        void NotifyObserver();
    }
}
