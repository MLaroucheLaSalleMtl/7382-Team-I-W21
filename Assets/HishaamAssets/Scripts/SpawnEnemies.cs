using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemyToSpawn;
    float lifeTime = 5.0f;                                                          

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Instantiate(enemyToSpawn, transform.position, transform.rotation);
            DestroyExplosion();


            //Spawning more than 1 enemy
            //GameObject go1 = (GameObject)Instantiate(enemyToSpawn, transform.position, transform.rotation);
            //GameObject go2 = (GameObject)Instantiate(enemyToSpawn, transform.position, transform.rotation);
           
        }
    }

    public void DestroyExplosion()
    {
        Destroy(gameObject, lifeTime);
    }
        

}
