using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public Transform[] spawnPoints; // array of spawn points
    public GameObject pipePrefab; // Pipe prefab reference

    public float timeToSpawn = 2f;
    public float timeBetweenSpawns = 1f;

    void SpawnPipe()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length); // random index from 0 to length of spawnPoints array
        Instantiate(pipePrefab, spawnPoints[randomIndex].position, Quaternion.identity); // instantiate pipePrefab at random spawn point
    }

    void Update()
    {
        if (Time.time >= timeToSpawn) // if time is greater than or equal to timeToSpawn
        {
            SpawnPipe(); // spawn pipe
            timeToSpawn = Time.time + timeBetweenSpawns; // set timeToSpawn to current time + timeBetweenSpawns
        }
    }
}
