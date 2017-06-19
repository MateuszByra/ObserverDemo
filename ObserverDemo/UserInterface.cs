using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class UserInterface : IObserver
    {
        public void Update(ISubject sender)
        {
            Console.WriteLine($"Hey user, look at {sender.Data.ToUpper()}");
        }
    }
}
