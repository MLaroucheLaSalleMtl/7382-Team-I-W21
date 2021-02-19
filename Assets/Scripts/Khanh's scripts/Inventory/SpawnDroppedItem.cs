using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDroppedItem : MonoBehaviour
{
    [SerializeField] private GameObject spawnedItem; // Reference to spawned item
    private Transform heroPosition; //Reference to the hero's position
    // Start is called before the first frame update
    void Start()
    {
        heroPosition = GameObject.FindWithTag("Player").transform;
    }

    public void Spawn()
    {
        Vector2 spawnPosition = new Vector2(heroPosition.position.x, heroPosition.position.y + 1); //Set the spawn position
        Instantiate(spawnedItem, spawnPosition, Quaternion.identity);
    }
}
