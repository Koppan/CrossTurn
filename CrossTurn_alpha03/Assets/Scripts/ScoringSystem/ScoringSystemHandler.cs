using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystemHandler : MonoBehaviour
{
    static public int GAMESCORE = 0;

    [SerializeField]
    private Text scoreLabel;
    void Update() {
        GAMESCORE = cap(GAMESCORE, 0);
        scoreLabel.text = $"SCORE: {GAMESCORE}";   // "Score: 5"
        //scoreLabel.text = "Hallo";
        
        // $"{variable}"
        //print($"Score: {derzeitige Score ist}"); -> Score: 5
        
    }

    int cap(int topValue, int capValue)
    {
        if (topValue < capValue){
            topValue = capValue;
        }
        return topValue;
    }
}
