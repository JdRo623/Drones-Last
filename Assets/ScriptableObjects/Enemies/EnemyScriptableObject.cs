using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu (fileName ="New Enemy", menuName = "Enemy")]
public class EnemyScriptableObject : ScriptableObject
{
    public float LifePoints;
    public float Damage;
    public float DamageRadius;

    //NavMeshAgent
    public float AIUpdateInterval;
    public float Acceleration;
    public float AngularSpeed;
    public int AreaMask;
    public int AvoidancePriority;
    public float Height;
    public ObstacleAvoidanceType ObstacleAvoidanceType;
    public float radius;
    public float Speed;
    public float StoppingDistance;
    public float BaseOffset;

}
