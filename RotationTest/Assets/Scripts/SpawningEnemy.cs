using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class SpawningEnemy : MonoBehaviour
{

    public GameObject enemy;
    public int[] spawnPos;
    public int movementSpeed;

    private int spawn;
    private int spawnIndex;

    private List<GameObject> enemies = new List<GameObject>();
    private GameObject ENEMY;
    private string direction;


    // Start is called before the first frame update
    void Start()
    {
        GameObject a = Instantiate(enemy) as GameObject; 
        StartCoroutine(waveOfDDoooom(a));
    }

    private void spawnEnemy(GameObject a){

        spawnIndex = Random.Range (0, spawnPos.Length);
        spawn = spawnPos[spawnIndex];

        switch (spawn)
        {
            case 1:
                direction = "DOWN";
                spawnTop(a);
                break;
            case 2:
                direction = "UP";
                spawnBottom(a);
                break;
            case 3:
                direction = "RIGHT";
                spawnLeft(a);
                break;
            case 4:
                direction = "LEFT";
                spawnRight(a);
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }


    private void spawnTop(GameObject a){
        a.transform.position = new Vector3(0, 10, 0);
    }

    private void spawnBottom(GameObject a){
        a.transform.position = new Vector3(0, -10, 0);
    }

    private void spawnLeft(GameObject a){
        a.transform.position = new Vector3(-10, 0, 0);
    }

    private void spawnRight(GameObject a){
        a.transform.position = new Vector3(10, 0, 0);
    }

    IEnumerator waveOfDDoooom(GameObject a){
        while (true)
        {
            yield return new WaitForSeconds(2);
            spawnEnemy(a);
            enemies.Add(a);
        }

    }

    private void Move(GameObject a, string dir){
        if (dir == "UP")
        {
            a.transform.Translate(0, movementSpeed * Time.deltaTime, 0);
        }else if (dir == "DOWN")
        {
            a.transform.Translate(0, -(movementSpeed * Time.deltaTime), 0);
        }else if (dir == "LEFT")
        {
            a.transform.Translate( -(movementSpeed * Time.deltaTime), 0, 0);
        }else if (dir == "RIGHT")
        {
            a.transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        }
    }


    void OnCollisionEnter(Collision col){
        if (col.gameObject.name == "PlayerHearth")
        {
            Debug.Log("COLLISIIIOOOONNN!!!");
            Debug.Log(enemies);
        }
    }


    // Update is called once per frame
    void Update()
    {
        ENEMY = enemies[0];
        Move(ENEMY, direction);
    }
}
