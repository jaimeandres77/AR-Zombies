using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombies : MonoBehaviour
{


    public GameObject[] spawners;
    public GameObject enemy;

    public int waveNumber,enemySpawnAmount,enemiesKilled;


    void Start()
    {

        waveNumber = 0;
        enemySpawnAmount = 0;
        enemiesKilled = 0;
        spawners = new GameObject[4];

        for (int i = 0; i < spawners.Length;i++)
        {
            spawners[i] = transform.GetChild(i).gameObject;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesKilled >= enemySpawnAmount)
        {
           nextWave();
        }
        
    }

    private void spawnEnemy()
    {

        int spawnerID = Random.Range(0,spawners.Length);
        Instantiate(enemy,spawners[spawnerID].transform.position,spawners[spawnerID].transform.rotation);
    }

    public void startWave()
    {
        waveNumber = 1;
        enemySpawnAmount = 2;
        enemiesKilled = 0;

        for (int i = 0; i < enemySpawnAmount; i++)
        {
            spawnEnemy();
        }
    }

    public void nextWave()
    {
        waveNumber++;
        enemySpawnAmount += 2;
        enemiesKilled = 0;

        for (int i = 0;i<enemySpawnAmount;i++)
        {
            spawnEnemy();
        }
    }


}
