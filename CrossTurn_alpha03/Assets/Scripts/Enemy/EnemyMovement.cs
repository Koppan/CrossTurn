using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 10f;
    [HideInInspector]
    public Vector3 direction = new Vector3(0, 0,  0);
    void FixedUpdate()
    {
        transform.Translate(
            -movementSpeed * Time.deltaTime * direction.x,
            -movementSpeed * Time.deltaTime * direction.y,
            -movementSpeed * Time.deltaTime * direction.z
            );
    }
}
