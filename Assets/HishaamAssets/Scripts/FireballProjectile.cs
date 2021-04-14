using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballProjectile : MonoBehaviour
{
    public float moveSpeed = 20f;
    public GameObject fireBall;
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
        maNaScr.mana -= 5f;
        Destroy(fireBall, 5.0f);
    }

    //Damage to the boss Crab Projectile
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Crab"))
        {
            collision.GetComponentInChildren<HealthBarBoss>().hp -= 10;
            collision.GetComponentInChildren<HealthBarBoss>().Die();

        }
    }

}
