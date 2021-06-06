using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PoolPattern
{
    public class PrimaryEnemyObjectPool: Pool
    {
        public static PrimaryEnemyObjectPool current;

        public void Awake()
        {
            current = this;
        }

       

    }
}
