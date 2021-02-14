using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehaviour : StateMachineBehaviour
{
    private Transform target;
    private bool isAttacking;
    [SerializeField] private float attackRange;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float minimumDistanceToTarget;
    public float attackCooldown;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float minimumDistanceToTarget = Vector2.Distance(animator.transform.position, target.position);
        
        if (minimumDistanceToTarget <= attackRange)
        {   
            attackCooldown = attackSpeed;
            isAttacking = true;           
        }

        if(isAttacking)
        {
            if (attackCooldown > 0)
            {
                attackCooldown -= 0.5f;
            }
            else if (attackCooldown <= 0 || minimumDistanceToTarget > attackRange) //After performing an attack, wait for an amount of second before able to perform another attack.
            {
                isAttacking = false;
                animator.SetBool("isAttacking", false);
            }
        }
        
    }
}
