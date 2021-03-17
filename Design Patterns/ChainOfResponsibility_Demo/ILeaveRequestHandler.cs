using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Demo
{
    public interface ILeaveRequestHandler
    {
        ILeaveRequestHandler nextHandler { get; }
        void HandleRequest(int days);
    }
}
