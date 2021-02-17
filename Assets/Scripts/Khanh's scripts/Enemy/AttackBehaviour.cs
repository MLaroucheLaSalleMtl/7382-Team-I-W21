using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehaviour : StateMachineBehaviour
{
    private Transform target;
    private bool isAttacking;
    [SerializeField] private float attackRange;
    [SerializeField] private float attackDelay;
    private float lastAttackTime;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float distanceToPlayer = Vector2.Distance(animator.transform.position, target.position);  
        
        if (distanceToPlayer <= attackRange) //Check the distance between the enemy and the hero
        {
            if (Time.time > lastAttackTime + attackDelay) //Check to see if the enemy can perform another attack by checking if the time has passed enough since the last attack
            {
                lastAttackTime = Time.time; //Record the time the enemy last attack
                isAttacking = true;
            }
            else //Return to the walking state while waiting for the next attack
            {
                isAttacking = false;
                animator.SetBool("isAttacking", false);
            }
        }

        if(distanceToPlayer > attackRange) //Avoid the enemy stucks in the attack animation when the hero moves out of the range while the enemy is attacking.
        {
            isAttacking = false;
            animator.SetBool("isAttacking", false);
        }
    }
}
