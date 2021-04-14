using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodyFightCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<ZombieHealth>().BFHurt();
        }
    }
}
