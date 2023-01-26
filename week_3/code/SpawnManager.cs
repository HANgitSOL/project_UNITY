using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    private float spawnRange = 9.0f;

    public int enemyCount;

    public int waveNumber = 1;

    public GameObject powerUpPrefab;
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(enemyPrefab, new Vector3(0,0,6), enemyPrefab.transform.rotation);
        // make enemy in specific location

        // float spawnPosX = Random.Range(-spawnRange,spawnRange);
        // float spawnPosZ = Random.Range(-spawnRange,spawnRange);

        // Vector3 randomPos = new Vector3(spawnPosX,0,spawnPosZ);

        // Instantiate(enemyPrefab, randomPos, enemyPrefab.transform.rotation);
        // make enemy in random location

        // for(int i = 0; i < 3; i++) // initial value; condition; manipulation
        // {
        //     Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        // }
        // use private fucntion

        SpawnEenemy(waveNumber);
        Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0)
        {
            waveNumber++; // every time when there is no enemy, make one more enemies
            SpawnEenemy(waveNumber);
            Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);
            // make more powerup-object every time the enemies is present
        }
        // check the number of enemy
        // if there is no enemy object, call SpawnEnemy and make one enemy object
    }

    void SpawnEenemy(int enemiesToSpawn) // identify the number of enemies when this function is used
    {
        for(int i = 0; i < enemiesToSpawn; i++) // initial value; condition; manipulation
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    // if you want to return specific value, do not use void and then use specific type of data which will be returned
    {
        float spawnPosX = Random.Range(-spawnRange,spawnRange);
        float spawnPosZ = Random.Range(-spawnRange,spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX,0,spawnPosZ);

        return randomPos;
    }
}
