using System;
namespace MSCourse
{
    public class Customer : ILoyaltyCardHolder
    {
        private int totalPoints;

        public int TotalPoints
        {
            get
            {
                return totalPoints;
            }
        }

        public void AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
        }

        public void ResetPoints()
        {
            int points = 0;
            totalPoints = points;
        }

        public Customer()
        {
        }
    }
}
