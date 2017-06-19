using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class Doer : ISubject
    {
        private IList<IObserver> observers = new List<IObserver>();
        public string Data { get; private set; }

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void DoSomething(string data)
        {
            this.Data = data;
            this.Notify();
        }

        public void Notify()
        {
            foreach (IObserver observer in this.observers)
                observer.Update(this);
        }
    }
}
