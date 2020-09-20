using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public GameObject enemy1;
    
    // Start is called before the first frame update
    void Start()
    {
        moveEnemy();
        
    }

    private void moveEnemy(){
        GameObject a = Instantiate(enemy1) as GameObject;
        a.transform.position = new Vector3(0, -3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
