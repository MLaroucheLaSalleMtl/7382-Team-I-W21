using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private GameObject spawnPosition, enemySpawner;
    Quaternion spawnRotation = Quaternion.identity;
    private int amountOfEnemySpawn =3;
    bool isSpawning;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Spawn()
    {
        int randomEnemy = Random.Range(0, enemies.Length);
       
        for (int i = 0; i < amountOfEnemySpawn; i++)
        {
            Instantiate(enemies[randomEnemy], spawnPosition.transform.position, spawnRotation);
            Destroy(enemySpawner);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isSpawning = true;
            Spawn();
        }
    }
}
