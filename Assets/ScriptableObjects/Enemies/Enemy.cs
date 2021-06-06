using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PrimaryEnemy : ScriptableObject
{
    public float lifePoints;
    public GameObject model;
    public float speed;
    public float damage;
}
