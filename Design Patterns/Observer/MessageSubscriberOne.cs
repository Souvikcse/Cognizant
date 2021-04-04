using System;

namespace Observer
{
    partial class Program
    {
        public class MessageSubscriberOne : IObserver
        {
            public void Update(Message m)
            {
                Console.WriteLine("MessageSubscriberOne : " + m.GetMessageContent());
            }
        }
    }
}
