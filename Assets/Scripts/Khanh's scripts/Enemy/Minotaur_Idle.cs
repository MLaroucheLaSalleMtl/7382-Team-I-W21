using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minotaur_Idle : StateMachineBehaviour
{
    private Transform target;

    [SerializeField] private float chaseRange; //The distance that enemy can start chasing
    [SerializeField] private float attackRange;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Vector3.Distance(target.position, animator.transform.position) <= chaseRange && Vector3.Distance(target.position, animator.transform.position) > attackRange)
        {
            //The enemy only chase within a certain distance.
            //If the distance between enemy and hero is less than the minimmumDistanceToTarget, the enemy will stop chasing, which means it will not push the hero.
            animator.SetBool("isChasing", true); //Trigger the bool to true to allow animations                 
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
