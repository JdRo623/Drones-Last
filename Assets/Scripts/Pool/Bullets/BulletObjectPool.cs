using PoolPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObjectPool : Pool
{
    public static BulletObjectPool current;

    public void Awake()
    {
        current = this;
    }
}
