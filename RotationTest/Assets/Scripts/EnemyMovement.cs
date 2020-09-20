using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {   
    }

    private void moveEnemy(){
        enemy.transform.position = new Vector3(0, -3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
    }
}
