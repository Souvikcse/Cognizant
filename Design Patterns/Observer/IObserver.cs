namespace Observer
{
    partial class Program
    {
        public interface IObserver
        {
            void Update(Message m);
        }
    }
}
