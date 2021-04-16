using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BossAttRange : MonoBehaviour
{

    [SerializeField] private float attackRange;
    private Transform target;

    private Animator anim;
    public GameObject proJectile;
    public Transform point;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position,target.position)>=attackRange)
        {
            anim.SetBool("IsProj", false);
            //patrol
        }
        else
        {
            anim.SetBool("IsProj", true);
        }
    }

    //IEnumerator ExampleCoroutine()
    //{
        //Print the time of when the function is first called.
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);

        

        //yield on a new YieldInstruction that waits for 5 seconds.
        //yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        //Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    //}

    
    public void Ball()
    {
        Instantiate(proJectile, point.position, Quaternion.identity);
        //StartCoroutine(ExampleCoroutine());
    }
}
