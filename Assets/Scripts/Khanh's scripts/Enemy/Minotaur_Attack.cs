using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minotaur_Attack : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float attackRadius;
    [SerializeField] private Vector3 offset;
    [SerializeField] private LayerMask attackMask;
    // Start is called before the first frame update
    public void Attack()
    {
        Vector3 position = transform.position;
        position += transform.right * offset.x;
        position += transform.up * offset.y;

        Collider2D collisionInfo = Physics2D.OverlapCircle(position, attackRadius, attackMask);
        if (collisionInfo != null)
        {
            collisionInfo.GetComponent<PlayerHealth>().Hurt();
        }
    }
}
