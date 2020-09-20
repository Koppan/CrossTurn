using System.Collections;
using UnityEngine;

public class SpawningEnemy : MonoBehaviour
{

    public GameObject enemy;
    public int[] spawnPos;
    public int movementSpeed;

    private int spawn;
    private int spawnIndex;


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
                spawnTop(a);
                break;
            case 2:
                spawnBottom(a);
                break;
            case 3:
                spawnLeft(a);
                break;
            case 4:
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
            a.transform.Translate(0,7,0);
            spawnEnemy(a);
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
