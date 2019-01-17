using System;
namespace MSCourse
{
    public class Coffee : IBeverage, IInventoryItem
    {
        public Coffee()
        {
        }

        //public interface IBeverage
        //{
        //    int GetServingTemperature(bool includesMilk);

        //    bool IsFairTrade { get; set; }

        //    event EventHandler OnSoldOut;

        //    string this[int index] { get; set; }

        //}

        private bool isFairTrade;
        private int servingTempWithoutMilk { get; set; }
        private int servingTempWithMilk { get; set; }

        public event EventHandler OnSoldOut;

        public bool IsFairTrade { get => isFairTrade; set => isFairTrade = value; }

        public string this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int GetServingTemperature(bool includesMilk)
        {
            if (includesMilk)
            {
                return servingTempWithMilk;
            }
            else
            {
                return servingTempWithoutMilk;
            }
        }
    }
}
