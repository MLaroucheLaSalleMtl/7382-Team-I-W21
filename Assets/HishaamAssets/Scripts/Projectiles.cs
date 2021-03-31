using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float moveSpeed;

    private float lifeTime;
    [SerializeField] private float liFe=2.0f;

    public GameObject proOrbDestroy;
    public GameObject proOrb;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

        lifeTime += Time.deltaTime;
        if(lifeTime>=liFe)
        {
            Instantiate(proOrb, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Instantiate(proOrbDestroy, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
