using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    public TMP_Text scoreHandler;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.OnEnemyDeath += OnEnemyDeath;
        score = 0;
        scoreHandler.SetText(score.ToString());
    }

    // Update is called once per frame
    void OnEnemyDeath()
    {
        score += 100;
        scoreHandler.SetText(score.ToString());

    }
}
