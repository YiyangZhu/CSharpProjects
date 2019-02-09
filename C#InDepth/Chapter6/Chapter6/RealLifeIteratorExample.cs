using System;
using System.Collections.Generic;
using System.IO;

namespace Chapter6
{
    public class RealLifeIteratorExample
    {
        public DateTime StartDate;
        public DateTime EndDate;
        public static TimeTable timetable = new TimeTable();
        public static string filename;

        public struct TimeTable
        {
            public DateTime StartDate;
            public DateTime EndDate;
        }

        public RealLifeIteratorExample()
        {
        }

        public static void Demo()
        {
            for (DateTime day = timetable.StartDate; day <= timetable.EndDate; day = day.AddDays(1))
            {

            }

            using (TextReader reader = File.OpenText(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Do something with line
                }
            }
        }

        public IEnumerable<DateTime> DateRange
        {
            get
            {
                for (DateTime day = StartDate; day <= EndDate; day = day.AddDays(1))
                {
                    yield return day;
                }
            }
        }


    }
}
