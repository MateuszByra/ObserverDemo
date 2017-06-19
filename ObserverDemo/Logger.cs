using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class Logger : IObserver
    {
        public void Update(ISubject sender)
        {
            Console.WriteLine($"Writing down {sender.Data.ToUpper()}.");
        }
    }
}
