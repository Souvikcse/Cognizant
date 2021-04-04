using System;

namespace Observer
{
    partial class Program
    {
        public class MessageSubscriberThree : IObserver
        {
            public void Update(Message m)
            {
                Console.WriteLine("MessageSubscriberThree : " + m.GetMessageContent());
            }
        }
    }
}
