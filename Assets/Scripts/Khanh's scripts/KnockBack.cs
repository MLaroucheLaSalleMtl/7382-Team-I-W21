using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    [SerializeField] private float knockingDistance;
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag ("Enemy"))
        {
            //Vector2 difference = transform.position - collision.transform.position;
            //transform.position = new Vector2(transform.position.x + difference.x, transform.position.y + difference.y);
            Rigidbody2D enemyRb2d = collision.GetComponent<Rigidbody2D>();
            
            enemyRb2d.isKinematic = false;
            Vector2 difference = collision.transform.position - transform.position; // Need a vector2 for the AddForce function.
            difference *= knockingDistance;
            enemyRb2d.AddForce(difference, ForceMode2D.Impulse);
            enemyRb2d.isKinematic = true;
        }
    }
}
