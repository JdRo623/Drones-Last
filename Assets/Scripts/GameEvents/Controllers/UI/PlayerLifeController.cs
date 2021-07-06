using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeController : MonoBehaviour
{
    public Slider playerLifeSlider;
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.OnPlayerDamage += OnPlayerDamage;
        playerLifeSlider.maxValue = 100;
        playerLifeSlider.value=100;
    }

    // Update is called once per frame
    void OnPlayerDamage(int newLifePoints)
    {
        print("Damage");
        playerLifeSlider.value=newLifePoints;
    }
}
