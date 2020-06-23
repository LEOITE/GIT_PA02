using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public   GameObject[] Obstacle;
    private float NextSpawn = 0;
    private float SpawnInterval = 1;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= NextSpawn)
        {
            NextSpawn = Time.time + SpawnInterval;
            Vector3 SpawnPos = new Vector3(Random.Range(-6, 6), 0, 14);

            Instantiate(Obstacle[Random.Range(0, Obstacle.Length)], SpawnPos, transform.rotation);
        }
    }
}