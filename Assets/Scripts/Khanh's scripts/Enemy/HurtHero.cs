using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtHero : MonoBehaviour
{
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
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHealth>().Hurt();
        }
        
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<ZombieHealth>().Hurt();
            Debug.Log("Hurt once");
        }
        if (collision.CompareTag("Slime"))
        {
            collision.GetComponent<SlimeHealth>().Hurt();
        }

    }
}
