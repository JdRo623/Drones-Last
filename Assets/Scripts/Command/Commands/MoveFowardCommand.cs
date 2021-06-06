using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.Commands
{
    public class MoveFowardCommand : Command
    {
        private MovableObject movableObject;

        public MoveFowardCommand(MovableObject movableObject)
        {
            this.movableObject = movableObject;
        }


        public override void Execute()
        {
            movableObject.MoveForward();
        }

    }
}
