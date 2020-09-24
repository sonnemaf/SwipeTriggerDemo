using System;

namespace SwipeTriggerDemo {
    [Flags]
    public enum SwipeDirections {
        None = 0,
        Left = 1,
        Right = 2,
        Up = 4,
        Down = 8,
        LeftRight = Left | Right,
        UpDown = Up | Down,
        LeftDown = Left | Down,
        LeftUp = Left | Up,
        RightDown = Right | Down,
        RightUp = Right | Up,
        All = Left | Right | Up | Down,
    }
}
