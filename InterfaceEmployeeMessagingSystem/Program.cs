using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEmployeeMessagingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager developerManager = new EmployeeManager(new Developer());
            developerManager.Notify("Kodlama");

            EmployeeManager designerManager=new EmployeeManager(new Designer());
            designerManager.Notify("Tasarım");

            EmployeeManager manager=new EmployeeManager(new  Manager());
            manager.Notify("Ödeme");


        }
    }
}
