using System;

namespace SwipeTriggerDemo {
    static class Extensions {
        public static bool Between<T>(this T me, T lower, T upper) where T : IComparable<T> {
            return me.CompareTo(lower) >= 0 && me.CompareTo(upper) <= 0;
        }
    }
}
