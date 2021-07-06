using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoundUIController : MonoBehaviour
{
    public TMP_Text roundLabel;
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.OnRoundChange += OnRoundChange;
        roundLabel.SetText("1");
    }

    // Update is called once per frame
    void OnRoundChange(int newRound)
    {
        roundLabel.SetText(newRound.ToString());
    }
}
