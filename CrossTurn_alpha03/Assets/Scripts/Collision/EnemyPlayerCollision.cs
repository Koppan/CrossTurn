using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        //print($"{gameObject.name} collided with {col.collider.name}");
        Destroy(gameObject);
    }
}
