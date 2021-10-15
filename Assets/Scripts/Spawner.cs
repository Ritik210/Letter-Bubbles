using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemy;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 1.0f;
    int randEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            
            nextSpawn = Time.time + spawnRate;
            randEnemy = Random.Range(0, 12);
            randY = Random.Range(4f,1f);

            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(enemy[randEnemy], whereToSpawn, Quaternion.identity);
        }
    }

   
}
