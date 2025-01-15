using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Part_02
{
    internal class Duration
    {
        #region Attributes
        uint hours;
        private uint minutes;
        uint seconds;
        #endregion

        #region Properties
        public uint Hours
        {
            get { return hours; }
            set
            {
                hours = value;
            }
        }
        public uint Minutes
        {
            get { return minutes; }
            set
            {
                minutes = value;
                if (minutes > 59)
                {
                    minutes = value % 60;
                    Hours += value / 60;
                }
            }
        }
        public uint Seconds
        {
            get { return seconds; }
            set
            {
                seconds = value;
                if (seconds > 59)
                {
                    seconds = value % 60;
                    Minutes += value / 60;
                }
            }
        }
        #endregion

        #region Constructors
        public Duration(uint hours, uint minutes, uint seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(uint seconds)
        {
            Seconds = seconds;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{(Hours == 0 ? "" : $"Hours :{Hours}")}, {(Minutes == 0 ? "" : $"Minutes :{Minutes}")}, {(Seconds == 0 ? "" : $"Seconds :{Seconds}").Trim(',', ' ')}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            Duration another = (obj as Duration)!;
            if (another.Hours == Hours && another.Minutes == Minutes && another.Seconds == Seconds)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return 0;
        }

        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration
            (
                hours: (left?.Hours ?? 0) + (right?.Hours ?? 0),
                minutes: (left?.Minutes ?? 0) + (right?.Minutes ?? 0),
                seconds: (left?.Seconds ?? 0) + (right?.Seconds ?? 0)
            );
        }
        public static Duration operator +(Duration left, uint seconds)
        {
            return new Duration
            (
                hours: (left?.Hours ?? 0),
                minutes: (left?.Minutes ?? 0),
                seconds: (left?.Seconds ?? 0) + seconds
            );
        }
        public static Duration operator +(uint seconds, Duration right)
        {
            return new Duration
            (
                hours: (right?.Hours ?? 0),
                minutes: (right?.Minutes ?? 0),
                seconds: (right?.Seconds ?? 0) + seconds
            );
        }
        public static Duration operator ++(Duration right)
        {
            return new Duration
            (
                hours: (right?.Hours + 1 ?? 0),
                minutes: (right?.Minutes + 1 ?? 0),
                seconds: (right?.Seconds + 1 ?? 0)
            );
        }
        public static Duration operator --(Duration right)
        {
            return new Duration
            (
                hours: right?.Hours == null || right?.Hours == 0 ? 0 : right!.Hours - 1,
                minutes: right?.Minutes == null || right?.Minutes == 0 ? 0 : right!.Minutes - 1,
                seconds: right?.Seconds == null || right?.Seconds == 0 ? 0 : right!.Seconds - 1
            );
        }
        public static Duration operator -(Duration left, Duration right)
        {
            long hoursSub = (left?.Hours ?? 0) - (right?.Hours ?? 0)
                , minutesSub = (left?.Minutes ?? 0) - (right?.Minutes ?? 0)
                , secondsSub = (left?.Seconds ?? 0) - (right?.Seconds ?? 0);

            return new Duration
            (
                hours: hoursSub < 0 ? 0 : (uint)hoursSub,
                minutes: minutesSub < 0 ? 0 : (uint)minutesSub,
                seconds: secondsSub < 0 ? 0 : (uint)secondsSub
            );
        }
        public static bool operator >(Duration left, Duration right)
        {
            if (left is null || right is null)
                return false;

            if (left.Hours > right.Hours)
                return true;

            if (left.Hours == right.Hours)
            {
                if (left.Minutes > right.Minutes)
                    return true;
                if (left.Minutes == right.Minutes)
                {
                    if (left.Seconds > right.Seconds)
                        return true;
                }
            }
            return false;
        }
        public static bool operator <(Duration left, Duration right)
        {
            if (left is null || right is null)
                return false;

            if (left.Hours < right.Hours)
                return true;

            if (left.Hours == right.Hours)
            {
                if (left.Minutes < right.Minutes)
                    return true;
                if (left.Minutes == right.Minutes)
                {
                    if (left.Seconds < right.Seconds)
                        return true;
                }
            }
            return false;
        }
        public static bool operator ==(Duration left, Duration right)
        {
            if (left is null && right is null)
                return true;

            if (left is null || right is null)
                return false;

            return left.Hours == right.Hours
                    && left.Minutes == right.Minutes
                    && left.Seconds == right.Seconds ? true : false;
        }
        public static bool operator !=(Duration left, Duration right)
        {
            if (left is null && right is null)
                return false;

            if (left is null || right is null)
                return true;

            return left.Hours != right.Hours
                    || left.Minutes != right.Minutes
                    || left.Seconds != right.Seconds ? true : false;
        }
        public static bool operator <=(Duration left, Duration right)
        {

            if (left == right)// this will resolve left = right = null and if left or right is null
                return true;

            if (left > right)
                return false;

            return true;

            //another solution
            //if (left is null || right is null)
            //    return false;

            //if (left.Hours > right.Hours)
            //    return false;

            //if (left.Minutes > right.Minutes)
            //    return false;

            //if (left.Seconds > right.Seconds)
            //    return false;

            //return true;
        }
        public static bool operator >=(Duration left, Duration right)
        {

            if (left == right)// this will resolve left = right = null and if left or right is null
                return true;

            if (left < right)
                return false;

            return true;
        }
        public static bool operator true(Duration operand)
        {
            return operand is not null
                     && operand.Hours != 0
                     && operand.Minutes != 0
                     && operand.Seconds != 0 ? true : false;
        }
        public static bool operator false(Duration operand)
        {
            return operand is null
                     || (operand.Hours == 0
                        && operand.Minutes == 0
                        && operand.Seconds == 0
                       ) ? true : false;
        }
        public static explicit operator DateTime(Duration operand)
        {
            return new DateTime(
                new DateOnly(),
                new TimeOnly(Convert.ToInt32(operand?.Hours), Convert.ToInt32(operand?.Minutes ?? 0), Convert.ToInt32(operand?.Seconds ?? 0))
                );
        }
        #endregion
    }
}
