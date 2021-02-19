using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseBehaviour : StateMachineBehaviour
{
    
    private Transform target; //Create a target for the enemy to chase
    [SerializeField] private Transform originalPosition; // The position where the enemy originally stay

    private float changeDirection; //A variable that will indicate the enemy's direction

    [SerializeField] private float chaseRange; //The distance that enemy can start chasing
    [SerializeField] private float movementSpeed; //Speed of the enemy

    [SerializeField] private float attackRange;
    [SerializeField] private float attackDelay; 
    private float lastAttackTime;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        //originalPosition = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        if (Vector3.Distance(target.position, animator.transform.position) <= chaseRange && Vector3.Distance(target.position, animator.transform.position) > attackRange)
        {
            changeDirection = target.position.x - animator.transform.position.x; //The value from this calculation is either negative or positive, if less than -0.1, facing left. If bigger than 0.1, facing right.
            animator.transform.position = Vector3.MoveTowards(animator.transform.position, target.transform.position, movementSpeed * Time.deltaTime);
            //The MoveTowards function allows the enemy to chase the hero. It takes the enemy's and hero's position and the enemy's movement speed.
            animator.SetFloat("Horizontal", changeDirection);
        }    

        if(Vector3.Distance(target.position, animator.transform.position) > chaseRange) //If the hero is so far away, return to the original position.
        {
            changeDirection = originalPosition.position.x - animator.transform.position.x;
            animator.SetFloat("Horizontal", changeDirection);
            animator.transform.position = Vector3.MoveTowards(animator.transform.position, originalPosition.position, movementSpeed * Time.deltaTime);

            if (Vector3.Distance(animator.transform.position, originalPosition.position) == 0)
            {   
                animator.SetBool("isChasing", false);
                animator.SetBool("isPatrolling", true);
            }                        
        }

        float distanceToPlayer = Vector2.Distance(animator.transform.position, target.position);        

        if (distanceToPlayer <= attackRange) //Check the distance between the enemy and the hero
        {
            if(Time.time > lastAttackTime + attackDelay)//Check to see if the enemy can perform another attack by checking if the time has passed enough since the last attack
            {
                lastAttackTime = Time.time;//Record the time the enemy last attack
                animator.SetBool("isAttacking", true);
            }
        }        
    }
}
