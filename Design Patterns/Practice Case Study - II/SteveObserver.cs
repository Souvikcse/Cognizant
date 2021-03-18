﻿using System;

namespace Practice_Case_Study___II
{
    public class SteveObserver : INotificationObserver
    {
        public string Name { get; set; }
        public void OnServerDown()
        {
            Console.WriteLine(Name + " has been notified!");
        }
    }
}
