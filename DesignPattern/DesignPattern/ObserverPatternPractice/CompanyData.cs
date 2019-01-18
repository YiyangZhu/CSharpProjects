using System;
using System.Collections.Generic;

namespace DesignPattern.ObserverPatternPractice
{
    public class CompanyData : ISubjectTwo
    {
        private List<IObserverTwo> observers;
        private int revenue;
        private int earnings;

        public CompanyData()
        {
            observers = new List<IObserverTwo>();
        }

        public int Revenue { get => revenue; set => revenue = value; }
        public int Earnings { get => earnings; set => earnings = value; }

        public void NotifyObserver()
        {
            foreach(IObserverTwo o in observers)
            {
                o.Update(revenue,earnings);
            }
        }

        public void RegisterObserver(IObserverTwo o)
        {
            int i = observers.IndexOf(o);
            if (i < 0)
            {
                observers.Add(o);
            }
        }

        public void RemoveObserver(IObserverTwo o)
        {
            int i = observers.IndexOf(o);
            if(i >= 0)
            {
                observers.Remove(o);
            }
        }

        public void setData(int Revenue, int Earnings)
        {
            this.revenue = Revenue;
            this.Earnings = Earnings;
            NotifyObserver();
        }
    }
}
