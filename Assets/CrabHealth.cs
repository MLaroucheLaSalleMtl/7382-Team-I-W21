using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabHealth : MonoBehaviour
{
    public int health = 500;
    public GameObject death;

    public bool IsInvulnerable=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(int damage)
    {
        if (IsInvulnerable)
            return;

        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //GetComponent<Animator>().SetBool("Die", true);
        Instantiate(death, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
