using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int lifePoints;
    public GameObject endScreen;
    public GameObject playerScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage) {
        lifePoints -= damage;
        print("Life: " + lifePoints);
        GameEvents.current.PlayerDamage(lifePoints);
        if (lifePoints<=0) {
            playerScreen.SetActive(false);
            endScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
