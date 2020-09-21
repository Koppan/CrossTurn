using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpawningEnemy : MonoBehaviour
{

    // public GameObject enemy;
    public int movementSpeed;
    public int spawnPosXY;
    public Text ScoreLabel;

    private List<int> spawnPos = new List<int>();
    private int spawn;
    private int spawnIndex;

    private int score;

    private List<GameObject> enemies = new List<GameObject>();
    private GameObject ENEMY;
    private string direction;
    private Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {
        // GameObject a = Instantiate(enemy) as GameObject; 
        // StartCoroutine(waveOfDDoooom());
        spawnPos.Add(1);
        spawnPos.Add(2);
        spawnPos.Add(3);
        spawnPos.Add(4);
        spawnPos.Add(5);
        spawnPos.Add(6);
        spawnPos.Add(7);
        spawnPos.Add(8);
    }

    private void spawnEnemy(){

        spawnIndex = Random.Range (0, spawnPos.Count);
        spawn = spawnPos[spawnIndex];

        switch (spawn)
        {
            case 1:
                direction = "UP";
                pos = new Vector3(0, -spawnPosXY, 0);
                spawning(pos);
                break;
            case 2:
                direction = "DOWN";
                pos = new Vector3(0, spawnPosXY, 0);
                spawning(pos);
                break;
            case 3:
                direction = "LEFT";
                pos = new Vector3(spawnPosXY, 0, 0);
                spawning(pos);
                break;
            case 4:
                direction = "RIGHT";
                pos = new Vector3(-spawnPosXY, 0, 0);
                spawning(pos);
                break;
            case 5:
                direction = "LEFTDOWN";
                pos = new Vector3(spawnPosXY, spawnPosXY, 0);
                spawning(pos);
                break;
            case 6:
                direction = "LEFTUP";
                pos = new Vector3(spawnPosXY, -spawnPosXY, 0);
                spawning(pos);
                break;
            case 7:
                direction = "RIGHTDOWN";
                pos = new Vector3(-spawnPosXY, spawnPosXY, 0);
                spawning(pos);
                break;
            case 8:
                direction = "RIGHTUP";
                pos = new Vector3(-spawnPosXY, -spawnPosXY, 0);
                spawning(pos);
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }

    private void spawning(Vector3 pos){
        transform.position = pos;
    }

    // IEnumerator waveOfDDoooom(){
    //     while (true)
    //     {
    //         yield return new WaitForSeconds(2);
    //         spawnEnemy();
    //         // enemies.Add();
    //         // ENEMY = enemies[0];
    //     }

    // }

    private void Move(string dir){
        if (dir == "UP")
        {
            transform.Translate(0, movementSpeed * Time.deltaTime, 0);
        }else if (dir == "DOWN")
        {
            transform.Translate(0, -movementSpeed * Time.deltaTime, 0);
        }else if (dir == "LEFT")
        {
            transform.Translate( -movementSpeed * Time.deltaTime, 0, 0);
        }else if (dir == "RIGHT")
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
            Debug.Log("Moving Right");
        }else if (dir == "LEFTDOWN")
        {
            transform.Translate(-movementSpeed * Time.deltaTime, -movementSpeed * Time.deltaTime, 0);
        }else if (dir == "LEFTUP")
        {
            transform.Translate(- movementSpeed * Time.deltaTime, movementSpeed * Time.deltaTime, 0);
        }else if (dir == "RIGHTUP")
        {
            transform.Translate(movementSpeed * Time.deltaTime, movementSpeed * Time.deltaTime, 0);

        }else if (dir == "RIGHTDOWN")
        {
            transform.Translate(movementSpeed * Time.deltaTime, -movementSpeed * Time.deltaTime, 0);   
        }
    }


    void OnCollisionEnter(Collision col){
        // Debug.Log("HIT!");
        // Debug.Log(col.collider.name);
        spawnEnemy();
        if (col.collider.name == "Player.1" || col.collider.name == "Player.2")
        {
            //Sound  wenn das Kreuz gehittet ist
            AudioSource audio = col.gameObject.GetComponent<AudioSource>();
            audio.Play();
            score ++;
            UpdateScore(score);
        }
        else if (col.collider.name == "PlayerHearth")
        {
            //Sound wenn das Herz gehittet ist
            AudioSource audio = col.gameObject.GetComponent<AudioSource>();
            audio.Play();
            score -= 10;
            UpdateScore(score);
        }
        

        

    }
    private void UpdateScore(int points)
    {
        ScoreLabel.text = "Score: " + points;
    }

    // Update is called once per frame
    void Update()
    {
        Move(direction);
        Debug.Log(score);
    }

    
}


