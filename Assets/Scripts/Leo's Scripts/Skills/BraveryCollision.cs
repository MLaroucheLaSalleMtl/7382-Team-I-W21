using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BraveryCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<ZombieHealth>().BFHurt();
        }

        if (collision.CompareTag("Minotaur"))
        {
            collision.GetComponent<MinotaurHealth>().Hurt();
        }

        if (collision.CompareTag("Crab"))
        {
            collision.GetComponent<HealthBarBoss>().hp -= 20;
            collision.GetComponent<HealthBarBoss>().Die();
        }
    }
}
