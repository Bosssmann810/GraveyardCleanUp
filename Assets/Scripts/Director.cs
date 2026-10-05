using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Director : MonoBehaviour
{
    public GameObject[] enemySpawnPoints;
    public GameObject enemy1; 
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public int credits;
    public int selectedSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        credits = 3;
        StartCoroutine(SpawnCoolDown());
        StartCoroutine(AddCredits());
        StartCoroutine(AddEnemy2());
        StartCoroutine(AddEnemy3());
        StartCoroutine(AddEnemy4());
    }

    IEnumerator AddCredits()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            credits += 3;
            
        }
    }

    public void RetreaveCredits(int amount)
    {
        credits += amount;
    }

    public void SpawnEnemy()
    {
        if(credits >= 15)
        {
            credits -= 15;
            selectedSpawn = Random.Range(0, enemySpawnPoints.Length);
            Instantiate(enemy4, enemySpawnPoints[selectedSpawn].transform);
            return;

        }
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
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator AddEnemy2()
    {
        yield return new WaitForSeconds(60);
        credits += 5;
    }
    IEnumerator AddEnemy3()
    {
        yield return new WaitForSeconds(90);
        credits += 10;
    }
    IEnumerator AddEnemy4()
    {
        yield return new WaitForSeconds(120);
        {
            credits += 15;
        }
    }
    private void Update()
    {
        //SpawnEnemy();
    }
}
