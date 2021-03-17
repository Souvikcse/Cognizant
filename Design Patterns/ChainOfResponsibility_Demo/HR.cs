using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Demo
{
    public class HR : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { 
            get => null;
        }

        public void HandleRequest(int days)
        {
            Console.WriteLine("Leave approved by HR");
        }
    }
}
