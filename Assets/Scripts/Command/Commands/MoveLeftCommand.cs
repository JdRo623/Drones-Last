

namespace CommandPattern.Commands {
    public class MoveLeftCommand : Command
    {
        private MovableObject movableObject;

        public MoveLeftCommand(MovableObject movableObject)
        {
            this.movableObject = movableObject;
        }

        public override void Execute()
        {
            movableObject.TurnLeft();
        }

    }
}

