using System;
namespace DesignPattern.ObserverPatternPractice
{
    public class CurrentConditionsDisplayTwo : IObserverTwo, IDisplayElementTwo
    {
        private int revenue;
        private int earnings;
        private CompanyData companyData;

        public CurrentConditionsDisplayTwo(CompanyData companyData)
        {
            this.companyData = companyData;
            companyData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: revenue is $"+revenue+" and earnings is $"+earnings+".");
        }

        public void Update(int r, int e)
        {
            revenue = r;
            earnings = e;
            Display();
        }
    }
}
