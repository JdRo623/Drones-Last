using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class RoundHandlers : MonoBehaviour
{
    public int firstRoundEnemyNumber;
    public int seed;
    private double K_INITIAL_VALUE;
    private int primaryEnemiesRoundQuantity;
    private int enemiesSpawned;

    private int enemiesLeft;
    private int currentRound;
    public float delay;
    public float roundDelay;
    public bool spawning = true;
    public EnemySpawnHandler EnemySpawnHandlers;
    // Start is called before the first frame update
    void Start()
    {
        K_INITIAL_VALUE = MathUtils.KGgenerator(firstRoundEnemyNumber, seed);
        currentRound = 1;
        GameEvents.current.OnEnemyDeath += OnEnemyDeath;
        InitNewRound();
    }

    public void StartSpawning()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (spawning && enemiesSpawned< primaryEnemiesRoundQuantity)
        {
            yield return new WaitForSeconds(delay);
            EnemySpawnHandlers.SpawnPrimaryEnemy();
            enemiesSpawned++;
        }
    }

    public void InitNewRound() {
        enemiesSpawned = 0;
        primaryEnemiesRoundQuantity = MathUtils.ExponentialGrow(firstRoundEnemyNumber, K_INITIAL_VALUE, currentRound);
        enemiesLeft = primaryEnemiesRoundQuantity;
        print(primaryEnemiesRoundQuantity);
        StartSpawning();
       // Task.Delay(1000).ContinueWith(t => StartSpawning());
    }

    public void EndRound() {
        spawning = false;
        currentRound++;
        GameEvents.current.RoundChange(currentRound);

    }

    void OnEnemyDeath()
    {
        enemiesLeft--;
        print(enemiesLeft);
        if (enemiesLeft ==0) {
            EndRound();
        }

    }
}
