using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.Commands
{
    public class RotateCommand : CommandParam
    {
        private MovableObject movableObject;

        public RotateCommand(MovableObject movableObject)
        {
            this.movableObject = movableObject;
        }


        public override void Execute(Vector2 reference)
        {
            movableObject.Rotate(reference);
        }

    }
}

