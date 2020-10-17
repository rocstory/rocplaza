using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcSpawner : MonoBehaviour
{
    public GameObject npc;
    public float spawnRate = 2f; // in seconds

    Vector2 whereToSpawn;
    float nextSpawn = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            //randX = Random.Range(-8.4f, 8.4);
            whereToSpawn = new Vector2(transform.position.x, transform.position.y);
            Instantiate(npc, whereToSpawn, Quaternion.identity);
        }
    }
}
