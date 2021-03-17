using System;

namespace ChainOfResponsibility_Demo
{
    public class ProjectManager : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler
        {
            get => new HR();
        }

        public void HandleRequest(int days)
        {
            if (days >= 4 && days <= 5)
            {
                Console.WriteLine("Leave approved by Project Manager");
            }
            else
            {
                nextHandler.HandleRequest(days);
            }
        }
    }
}
