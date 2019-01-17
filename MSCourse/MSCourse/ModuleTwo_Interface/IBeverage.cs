using System;
namespace MSCourse
{
    public interface IBeverage
    {
        int GetServingTemperature(bool includesMilk);

        bool IsFairTrade { get; set; }

        event EventHandler OnSoldOut;

        string this[int index] { get; set; }

    }
}
