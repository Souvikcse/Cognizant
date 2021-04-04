using System;

namespace Observer
{
    partial class Program
    {
        public class MessageSubscriberTwo : IObserver
        {
            public void Update(Message m)
            {
                Console.WriteLine("MessageSubscriberTwo : " + m.GetMessageContent());
            }
        }
    }
}
