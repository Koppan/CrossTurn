using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class EnemySpawning : MonoBehaviour
{

    [SerializeField]
    private float spawnRadius = 10f;

    [SerializeField]
    private GameObject enemy;

    [SerializeField]
    private Vector3 targetPos = new Vector3(0,0,0);

    private GameObject spawnedEnemy;
    private Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnEnemies");
    }

    IEnumerator SpawnEnemies() 
    {
        while (true)
        {
            
            yield return new WaitForSeconds(1);
            //print("Spawning");

            spawnedEnemy = Instantiate(enemy);    
            Vector3 pos = getRadialSpawningPositions()[UnityEngine.Random.Range(0, 359)];

            Vector3 dir = - (targetPos - pos) ;
            spawnedEnemy.GetComponent<EnemyMovement>().direction = dir;

            spawnedEnemy.transform.position = pos;
            //print($"{spawnedEnemy.transform.position}");
        }
    }

    List<Vector3> getRadialSpawningPositions()
    {
        List<Vector3> positions = new List<Vector3>();
        for (int ang = 0; ang < 360; ang++) 
        {
            float r = spawnRadius;
            float x = (float) (r * Math.Cos(ang));
            float y = (float) (r * Math.Sin(ang));
            positions.Add(new Vector3(x, y, 0));
        }
        return positions;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
