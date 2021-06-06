using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.Commands
{
    public class ShootCommand : Command
    {
        
        public ShootCommand()
        {
        }


        public override void Execute()
        {
            Debug.Log("SHOOT");
        }

    }
}