using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtHero : MonoBehaviour
{
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHealth>().Hurt();
        }
        
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<ZombieHealth>().Hurt(zombieHurt: 1); 
        }
        if (collision.CompareTag("Slime"))
        {
            collision.GetComponent<SlimeHealth>().Hurt();
        }
        if(collision.CompareTag("Minotaur"))
        {
            collision.GetComponent<MinotaurHealth>().Hurt();
        }
    }
}
