using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.Commands
{
    public class MoveBackCommand : Command
    {
        private MovableObject movableObject;

        public MoveBackCommand(MovableObject movableObject)
        {
            this.movableObject = movableObject;
        }

        public override void Execute()
        {
            movableObject.MoveBack();
        }

    }
}
