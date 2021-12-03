using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearth_collision : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemy")) {
            Destroy(collision.gameObject);
        }
        //print($"Ball flew away: {collision}\n collider: {gameObject}");
    }
}
