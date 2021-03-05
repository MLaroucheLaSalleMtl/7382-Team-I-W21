using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    [SerializeField] private float knockingDistance, knockBackTime;
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag ("Enemy"))
        {
            Rigidbody2D enemyRb2d = collision.GetComponent<Rigidbody2D>();
            if(enemyRb2d !=null)
            {
                enemyRb2d.isKinematic = false;
                Vector2 direction = enemyRb2d.transform.position - transform.position; // Need a vector2 for the AddForce function.
                direction = direction.normalized * knockingDistance;
                enemyRb2d.AddForce(direction, ForceMode2D.Impulse);
                StartCoroutine(KnockBackk(enemyRb2d));
            } 
        }
    }

    private IEnumerator KnockBackk(Rigidbody2D enemyRb2d)
    {
        if(enemyRb2d != null)
        {
            yield return new WaitForSeconds(knockBackTime);
            enemyRb2d.velocity = Vector2.zero;
            enemyRb2d.isKinematic = true;
        }
    }
}
