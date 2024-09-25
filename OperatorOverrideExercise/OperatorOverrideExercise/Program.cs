﻿using System;

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
                throw new ArgumentOutOfRangeException(
                    "Hour is out of range of 0-23");
            }
            if (minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException(
                    "Minute is out of range of 0-59");
            }
            Hour = hour;
            Minute = minute;
        }

        public override string ToString() =>
            $"{Hour.ToString("00")}:{Minute.ToString("00")}";

        public static bool operator ==(Time time1, Time time2) =>
            time1.Hour == time2.Hour &&
            time1.Minute == time2.Minute;

        public static bool operator !=(Time time1, Time time2) =>
            !(time1 == time2);

        public static Time operator +(Time time1, Time time2)
        {
            var hour = time1.Hour + time2.Hour;
            var minute = time1.Minute + time2.Minute;

            if (minute > 59)
            {
                hour++;
                minute -= 60;
            }

            return new Time(hour % 24, minute);
        }
    }

}
