using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.Commands
{
    public class MoveRightCommand : Command
    {
        private MovableObject movableObject;

        public MoveRightCommand(MovableObject movableObject)
        {
            this.movableObject = movableObject;
        }


        public override void Execute()
        {
            movableObject.TurnRight();
        }

    }
}