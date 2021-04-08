using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballProjectile : MonoBehaviour
{
    public float moveSpeed = 20f;
    public GameObject fireBall;
    public Transform firePoint;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(fireBall, firePoint.position, firePoint.rotation); 
        Destroy(fireBall, 5.0f);
    }

    


}
