using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHandler : MonoBehaviour
{
    public EnemyScriptableObject enemy;
    private float lifePoints;
    public NavMeshAgent navMeshAgent;
    private Transform player;
    public GameObject enemyObject;

    bool spawned;

    // Start is called before the first frame update
    void OnEnable()
    {
        lifePoints = enemy.LifePoints;
        SetuptAgentFromConfiguration();
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        enemyObject.transform.Translate(Vector3.up * 5);
        navMeshAgent.enabled = false;
        spawned = false;

    }

    public void SetuptAgentFromConfiguration() {
        navMeshAgent.acceleration = enemy.Acceleration;
        navMeshAgent.angularSpeed = enemy.AngularSpeed;
        navMeshAgent.areaMask = enemy.AreaMask;
        navMeshAgent.avoidancePriority = enemy.AvoidancePriority;
        navMeshAgent.baseOffset = enemy.BaseOffset;
        navMeshAgent.height = enemy.Height;
        navMeshAgent.obstacleAvoidanceType = enemy.ObstacleAvoidanceType;
        navMeshAgent.radius = enemy.radius;
        navMeshAgent.speed = enemy.Speed;
        navMeshAgent.stoppingDistance = enemy.StoppingDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawned)
        navMeshAgent.SetDestination(player.position);

        if (transform.position.y <= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
            spawned = true;
            navMeshAgent.enabled = true;
        }
    }

    public void TakeDamage(float damage, Vector3 hitPoint) {
        lifePoints -= damage;
        if (lifePoints <= 0) NotifyEnemyDeath();
    }

    private void NotifyEnemyDeath() {
        GameEvents.current.EnemyDeath();
        enemyObject.SetActive(false);
    }
}
