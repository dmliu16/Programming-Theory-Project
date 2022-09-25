using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyList;

    private float xSpawnPos = 15;
    private float zSpawnRange = 6;
    private float ySpawn = 0.5f;
    private Vector3 spawnLocation;

    private float enemySpawnTime = 1f;
    private float startupDelay = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomEnemyRandomSide), startupDelay, enemySpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemyRandomSide()
    {
        var randomSide = Random.Range(0, 2);
        var randomIndex = Random.Range(0, enemyList.Length);
        var randomEnemy = enemyList[randomIndex];
        var randomZLocation = Random.Range(-zSpawnRange, zSpawnRange);

        // If we spawn fish from the left
        if (randomSide < 1)
        {
            // Make the fish move right
            randomEnemy.GetComponent<MoveDirection>().direction = Vector3.right;
            // Spawn location
            spawnLocation = new Vector3(-xSpawnPos, ySpawn, randomZLocation);
        }
        // If we spawn fish from the right
        else
        {
            // Make the fish move right
            randomEnemy.GetComponent<MoveDirection>().direction = Vector3.left;
            // Spawn location
            spawnLocation = new Vector3(xSpawnPos, ySpawn, randomZLocation);
        }

        Instantiate(randomEnemy, spawnLocation, randomEnemy.transform.rotation);
    }
}
