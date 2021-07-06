using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    void Awake()
    {
        current = this;
    }
    public event Action<int> OnRoundChange;
    public void RoundChange(int round)
    {
        OnRoundChange?.Invoke(round);
    }

    public event Action<int> OnPlayerDamage;
    public void PlayerDamage(int newLifePoints)
    {
        OnPlayerDamage?.Invoke(newLifePoints);
    }


    public event Action OnEnemyDeath;

    public void EnemyDeath()
    {
        OnEnemyDeath?.Invoke();

    }

   
}
