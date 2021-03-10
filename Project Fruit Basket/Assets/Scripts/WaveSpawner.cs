using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform enemy2;
    public Transform deathBlock;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    private float countdown = 3f;
    private float timer = 90f;
    private int waveNumber;
    private int x;
    public TextMeshProUGUI gameTimer;

    
    void Update()
    {
        timer -= Time.deltaTime;
        if (countdown <= 0)
        {
            StartCoroutine(SpawnWave1());
            countdown = timeBetweenWaves;

            StartCoroutine(SpawnWave2());
        }
     
        countdown -= Time.deltaTime;
        gameTimer.text = Mathf.Round(timer).ToString();



        //Survive 90 seconds Victory Scene;
        if (timer <= 0.0)
        {
            SceneManager.LoadScene(2);
        }


    }

    IEnumerator SpawnWave1()
    {

        waveNumber++;
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1.5f);
            PlayerHandler.Money += 50;
        }
   
    }
    IEnumerator SpawnWave2()
    {
        for(int i = 0; i < 1; i++)
        {
            yield return new WaitForSeconds(15f);
            SpawnEnemy2();
            PlayerHandler.Money += 75;
        }

    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
    void SpawnEnemy2()
    {
        Instantiate(enemy2, spawnPoint.position, spawnPoint.rotation);
    }
}
