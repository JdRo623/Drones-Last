using PoolPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float spawnRange;
    public MapHandler mapHandler;
    private Vector3 spawnPosition;
    private Vector3 randomPosition;

    private Vector3 CalculateSpawnPoint()
    {
        spawnPosition = player.position;
        randomPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 0, Random.Range(-spawnRange, spawnRange));

        spawnPosition += randomPosition;

        while (!mapHandler.ValidatePositionWhitinRange(spawnPosition))
        {
            randomPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 0, Random.Range(-spawnRange, spawnRange));
            spawnPosition = player.position + randomPosition;
        }

        return spawnPosition;
    }

    public void SpawnPrimaryEnemy()
    {
        GameObject enemy = PrimaryEnemyObjectPool.current.GetPulledObject();
        if (enemy == null)
            return;
        enemy.transform.position = CalculateSpawnPoint();
        enemy.SetActive(true);
    }
}