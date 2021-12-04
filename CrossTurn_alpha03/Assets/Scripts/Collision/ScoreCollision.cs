using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollision : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            ScoringSystemHandler.GAMESCORE += 1;
        }
        else if (col.CompareTag("hearth"))
        {
            ScoringSystemHandler.GAMESCORE -= 5;
        }
        print($"{ScoringSystemHandler.GAMESCORE}");
    }
}
