using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehaviour : StateMachineBehaviour
{
    private Transform target;

    [SerializeField] private float maximumDistanceToTarget; //The distance that enemy can start chasing
    [SerializeField] private float minimumDistanceToTarget;

    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Vector3.Distance(target.position, animator.transform.position) <= maximumDistanceToTarget && Vector3.Distance(target.position, animator.transform.position) > minimumDistanceToTarget)
        {
            //The enemy only chase within a certain distance.
            //If the distance between enemy and hero is less than the minimmumDistanceToTarget, the enemy will stop chasing, which means it will not push the hero.
            animator.SetBool("isChasing", true); //Trigger the bool to true to allow animations                 
        }
    }

}
