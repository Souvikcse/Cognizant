namespace Practice_Case_Study___II
{
    public interface INotificationObserver
    {
        string Name { get; set; }
        void OnServerDown();
    }
}
