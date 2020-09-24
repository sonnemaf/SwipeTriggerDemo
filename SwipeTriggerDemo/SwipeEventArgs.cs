using System;

namespace SwipeTriggerDemo {
    public class SwipeEventArgs : EventArgs {

        public SwipeDirections Directions { get; }

        public SwipeEventArgs(SwipeDirections directions) {
            this.Directions = directions;
        }

    }
}
