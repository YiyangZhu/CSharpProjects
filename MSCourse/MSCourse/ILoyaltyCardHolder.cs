using System;
namespace MSCourse
{
    public interface ILoyaltyCardHolder
    {
        int TotalPoints { get; } //read-only
        void AddPoints(decimal transactionValue);
        void ResetPoints();
    }
}
