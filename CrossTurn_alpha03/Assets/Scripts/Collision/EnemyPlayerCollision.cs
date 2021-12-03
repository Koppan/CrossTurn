using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        //print($"{gameObject.name} collided with {col.collider.name}");
        Destroy(gameObject);
    }
}
