using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public Transform target;
    private int wavepointIndex = 0;
    public Vector3 dir;
    private Enemy enemy;
    [Header("Enemy Health")]
    public int health = 100;

    public int moneyGain = 75;
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        PlayerHandler.Money += moneyGain;
    }

    void Start()
    {
      //  enemy = GetComponent<Enemy>();
        target = Waypoints.waypoints[0];
    }

    void Update()
    {
        dir = (target.position - transform.position);
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            getNextWaypoint();
        }
    }

    void getNextWaypoint()
    {
        if(wavepointIndex >= Waypoints.waypoints.Length - 1)
        {
            DeathBlock();
            return;

        }
        wavepointIndex++;
        target = Waypoints.waypoints[wavepointIndex];
    }

    void DeathBlock()
    {
        Destroy(gameObject);
        PlayerHandler.Lives--;
    }

}
