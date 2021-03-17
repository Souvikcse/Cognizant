using System;

namespace ChainOfResponsibility_Demo
{
    public class Supervisor : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler
        {
            get => new ProjectManager();
        }

        public void HandleRequest(int days)
        {
            if (days >=1 && days <= 3)
            {
                Console.WriteLine("Leave approved by Supervisor");
            }
            else
            {
                nextHandler.HandleRequest(days);
            }
        }
    }
}
