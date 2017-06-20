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
            UserInterface userInterface = new UserInterface();
            Logger logger = new Logger();

            doer.AfterDoSomethingWith += userInterface.AfterDoSomethingWith;
            doer.AfterDoSomethingWith += logger.AfterDoSomethingWith;
            //doer.AfterDoSomethingWith =
            //    new MulticastNotifier<string>(
            //        new IObserver<string>[]
            //        {
            //            userInterface.AfterDoSomethingWith,
            //            logger.AfterDoSomethingWith
            //        });
            doer.AfterDoMore += logger.AfterDoMore;
            //doer.AfterDoMore =
            //    new MulticastNotifier<Tuple<string, string>>(
            //        new IObserver<Tuple<string, string>>[]
            //        {
            //            logger.AfterDoMore
            //        });

            doer.DoSomethingWith("my data");
            doer.DoMore("tail");
            Console.ReadLine();
        }
    }
}
