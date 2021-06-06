using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundHandlers : MonoBehaviour
{
    public int firstRoundEnemyNumber;
    public int seed;
    private double K_INITIAL_VALUE;
    private int primaryEnemiesRoundQuantity;
    private int currentRound;
    public float delay;
    public bool spawning = true;
    public EnemySpawnHandler EnemySpawnHandlers;
    // Start is called before the first frame update
    void Start()
    {
        K_INITIAL_VALUE = MathUtils.KGgenerator(firstRoundEnemyNumber, seed);
        currentRound = 1;
        InitNewRound();
    }

    public void StartSpawning()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (spawning)
        {
            yield return new WaitForSeconds(delay);

            EnemySpawnHandlers.SpawnPrimaryEnemy();
        }
    }

    public void InitNewRound() {
        primaryEnemiesRoundQuantity = MathUtils.ExponentialGrow(firstRoundEnemyNumber, K_INITIAL_VALUE, currentRound);
        StartSpawning();
    }

    public void EndRound() { 
    
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
