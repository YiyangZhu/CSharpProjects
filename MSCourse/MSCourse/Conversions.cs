using System;
namespace MSCourse
{
    public class Conversions
    {
        public static double PoundsToKilos(double pounds)
        {
            double kilos = pounds * 0.4536;
            return kilos;
        }

        public static double KilosToPounds(double kilos)
        {
            double pounds = kilos * 2.205;
            return pounds;
        }

        public Conversions()
        {
        }
    }
}
