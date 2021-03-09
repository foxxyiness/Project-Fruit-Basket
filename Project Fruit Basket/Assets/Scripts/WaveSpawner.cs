using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    private float countdown = 3f;
    private float timer = 90f;
    private int waveNumber;
    public TextMeshProUGUI gameTimer;

    
    void Update()
    {
        timer -= Time.deltaTime;
        if (countdown <= 0)
        {
            StartCoroutine(SpawnWave1());
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
        gameTimer.text = Mathf.Round(timer).ToString();
    }

    IEnumerator SpawnWave1()
    {

        waveNumber++;
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(2f);
        }
      
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
