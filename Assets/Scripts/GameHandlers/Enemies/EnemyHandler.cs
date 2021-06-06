using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{

    private float lifePoints;
    // Start is called before the first frame update
    void Start()
    {
        lifePoints = GameHandler.primaryEnemyLife;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
