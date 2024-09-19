using System;

namespace Coding.Exercise
{
    public struct Time
    {
        public int Hour { get; }

        public int Minute { get; }

        public Time(int hour, int minute)
        {
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentOutOfRangeException(nameof(hour), "Hour must be between 0 and 23.");
            }

            if (minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException(nameof(minute), "Minute must be between 0 and 59.");
            }

            Hour = hour;
            Minute = minute;
        }

        public override string ToString() => $"{Hour.ToString("00")}:{Minute.ToString("00")}";
    }
}
