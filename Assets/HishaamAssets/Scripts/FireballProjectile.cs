using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballProjectile : MonoBehaviour
{
    public float moveSpeed = 20f;
    public GameObject fireBall;
    public GameObject fireBallEx;
    public Transform firePoint;
    public Rigidbody2D rb;


    public manaBar maNaScr;
    

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * moveSpeed;
        maNaScr = GameObject.Find("Hero").GetComponent<manaBar>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
           if(maNaScr.mana>=0)
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        Instantiate(fireBall, firePoint.position, firePoint.rotation);
        maNaScr.mana -= 10f;
        //Destroy(fireBall, 5.0f);
    }

    //Damage to the boss Crab Projectile
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Damage Crab
        if (collision.gameObject.tag == ("Crab"))
        {
            Destroy(gameObject);
            Instantiate(fireBallEx, transform.position, Quaternion.identity);
            collision.GetComponentInChildren<HealthBarBoss>().hp -= 20;
            collision.GetComponentInChildren<HealthBarBoss>().Die();
        }

        //Damage Zombie
        if(collision.gameObject.tag==("Enemy"))
        {
            Destroy(gameObject);
            Instantiate(fireBallEx, transform.position, Quaternion.identity);
            collision.GetComponent<ZombieHealth>().Hurt();
        }

        //Damage Minotaur
        if (collision.gameObject.tag == ("Minotaur"))
        {
            Destroy(gameObject);
            Instantiate(fireBallEx, transform.position, Quaternion.identity);
            collision.GetComponent<MinotaurHealth>().Hurt();
        }

    }

}
