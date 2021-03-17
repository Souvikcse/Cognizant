using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest lr = new LeaveRequest() { 
                EmployeeName = "Souvik",
                LeaveDays = 4
            };

            Supervisor supervisor = new Supervisor();
            supervisor.HandleRequest(lr.LeaveDays);

            Console.Read();
        }
    }
}
