using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minotaur_Walk : StateMachineBehaviour
{
    private Transform player;
    private Rigidbody2D rb2d;
    [SerializeField] private float movementSpeed, attackRange;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb2d = animator.GetComponent<Rigidbody2D>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<Flip>().FacePlayer();
        Vector2 target = new Vector2(player.position.x, player.position.y);
        Vector2 newPosition = Vector2.MoveTowards(rb2d.position, target, movementSpeed * Time.fixedDeltaTime);
        rb2d.MovePosition(newPosition);

        if(Vector2.Distance(player.position, rb2d.position) <= attackRange)
        {
            animator.SetTrigger("Attack");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack"); //Avoid animation repetition.
    }
}

