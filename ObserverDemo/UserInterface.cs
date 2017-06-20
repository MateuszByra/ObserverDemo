using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class UserInterface
    {
        public void AfterDoSomethingWith(object sender, string data)
        {
            Console.WriteLine("Hey user, look at {0}.", data.ToUpper());
        }
    }
}
