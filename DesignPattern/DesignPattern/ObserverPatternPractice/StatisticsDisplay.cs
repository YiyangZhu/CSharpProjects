using System;
using System.Collections.Generic;

namespace DesignPattern.ObserverPatternPractice
{
    public class StatisticsDisplayTwo : IObserverTwo, IDisplayElementTwo
    {
        private int revenue;
        private int earnings;
        private int averageRevenue;
        private int averageEarnings;
        private List<int> revenueList;
        private List<int> earningsList;
        private CompanyData companyData;

        public StatisticsDisplayTwo(CompanyData companyData)
        {
            this.companyData = companyData;
            companyData.RegisterObserver(this);
            revenueList = new List<int>();
            earningsList = new List<int>();
        }

        public void Display()
        {
            Console.WriteLine("Statistics: average revenue is $" + averageRevenue + " and average earnings is $" + averageEarnings + ".");
        }

        public void Update(int r, int e)
        {
            revenue = r;
            earnings = e;
            Calculate();
            Display();
        }

        public void Calculate()
        {
            revenueList.Add(revenue);
            earningsList.Add(earnings);
            int TotalRevenue = 0;
            int TotalEarnings = 0;

            foreach(int r in revenueList)
            {
                TotalRevenue += r;
            }

            foreach (int e in earningsList)
            {
                TotalEarnings += e;
            }

            averageRevenue = TotalRevenue / revenueList.Count;
            averageEarnings = TotalEarnings / earningsList.Count;
        }
    }
}
