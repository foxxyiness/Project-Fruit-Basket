using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform deathBlock;
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



        //Survive 90 seconds Victory Scene;
        if (timer <= 0.0)
        {
            SceneManager.LoadScene(2);
        }

        if(enemyPrefab == deathBlock)
        {
            Destroy(enemyPrefab);
            PlayerHandler.Lives = PlayerHandler.Lives - 1;
            Debug.Log("Hello");
        }
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
