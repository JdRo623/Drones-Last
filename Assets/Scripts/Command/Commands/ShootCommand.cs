using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.Commands
{
    public class ShootCommand : Command
    {
        private Weapon weapon;
        public ShootCommand(Weapon weapon)
        {
            this.weapon = weapon;
        }


        public override void Execute()
        {
            weapon.Shoot();
        }

    }
}