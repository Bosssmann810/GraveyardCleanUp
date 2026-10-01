using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Director : MonoBehaviour
{
    public GameObject[] enemySpawnPoints;
    public GameObject enemy1; 
    public GameObject enemy2;
    public GameObject enemy3;
    public int credits;
    public int selectedSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        credits = 3;
        StartCoroutine(SpawnCoolDown());
    }

    IEnumerator AddCredits()
    {
        credits += 1;
        yield return new WaitForSeconds(10);
    }

    public void RetreaveCredits(int amount)
    {
        credits += amount;
    }

    public void SpawnEnemy()
    {
        Debug.Log("Spawning");
        if (credits >= 10)
        {
            credits -= 10;
            selectedSpawn = Random.Range(0, enemySpawnPoints.Length);
            Instantiate(enemy3, enemySpawnPoints[selectedSpawn].transform);
            return;
        }
        if (credits >= 5)
        {
            credits -= 5;
            selectedSpawn = Random.Range(0, enemySpawnPoints.Length);
            Instantiate(enemy2, enemySpawnPoints[selectedSpawn].transform);
            return;
        }
        if(credits >= 1)
        {
            credits -= 1;
            selectedSpawn = Random.Range(0, enemySpawnPoints.Length);
            Instantiate(enemy1, enemySpawnPoints[selectedSpawn].transform);
            return;
        }
    }

    IEnumerator SpawnCoolDown()
    {
        SpawnEnemy();
        yield return new WaitForSeconds(1);
    }

    private void Update()
    {
        SpawnEnemy();
    }
}
