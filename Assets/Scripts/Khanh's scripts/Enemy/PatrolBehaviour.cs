using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBehaviour : StateMachineBehaviour
{
    [SerializeField] private float chaseRange; //The distance that enemy can start chasing
    [SerializeField] private float attackRange;
    private Transform target;

    public float movementSpeed;
    private float waitTime;
    public float startWaitTime;

    public Transform[] points;
    private int patrollingPoint;
    private float changeDirection;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        waitTime = startWaitTime;
        patrollingPoint = Random.Range(0, points.Length);        
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        changeDirection = points[patrollingPoint].position.x - animator.transform.position.x;
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, points[patrollingPoint].position, movementSpeed * Time.deltaTime);
        animator.SetFloat("Horizontal", changeDirection);

        if(Vector2.Distance(animator.transform.position, points[patrollingPoint].position) <= 0.2f)
        {
            
            if (waitTime > 0)
            {                
                waitTime -= Time.deltaTime;
            }
            if(waitTime <=0)
            {                
                patrollingPoint = Random.Range(0, points.Length);
                waitTime = startWaitTime;
            }            
        }

        if (Vector3.Distance(target.position, animator.transform.position) <= chaseRange && Vector3.Distance(target.position, animator.transform.position) > attackRange)
        {
            changeDirection = target.position.x - animator.transform.position.x; //The value from this calculation is either negative or positive, if less than -0.1, facing left. If bigger than 0.1, facing right.
            animator.transform.position = Vector3.MoveTowards(animator.transform.position, target.transform.position, movementSpeed * Time.deltaTime);
            //The MoveTowards function allows the enemy to chase the hero. It takes the enemy's and hero's position and the enemy's movement speed.
            animator.SetFloat("Horizontal", changeDirection);
            //The enemy only chase within a certain distance.
            //If the distance between enemy and hero is less than the minimmumDistanceToTarget, the enemy will stop chasing, which means it will not push the hero.
            animator.SetBool("isChasing", true); //Trigger the bool to true to allow animations                 
        }
    }
   
}
