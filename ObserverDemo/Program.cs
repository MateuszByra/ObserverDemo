using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Doer doer = new Doer();
            doer.Attach(new UserInterface());
            doer.Attach(new Logger());
            doer.DoSomething("my data");
            Console.ReadLine();
        }
    }
}
