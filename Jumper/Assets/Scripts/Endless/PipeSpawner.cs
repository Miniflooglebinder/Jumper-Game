using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject pipePrefab;

    public float timeBetweenWaves = 1f;
    private float timeToSpawn = 2f;

    void SpawnPipe()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length); // Randomly select a spawn point
        Instantiate(pipePrefab, spawnPoints[randomIndex].position, Quaternion.identity); // Spawn a pipe at the spawn point
    }

    void Update()
    {
        if (Time.time >= timeToSpawn) // If the time has reached the time to spawn
        {
            SpawnPipe(); // Spawn a pipe
            timeToSpawn = Time.time + timeBetweenWaves; // Set the time to spawn to the current time plus the time between waves
        }
    }
}
