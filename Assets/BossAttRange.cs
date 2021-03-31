using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void Ball()
    {
        Instantiate(proJectile, point.position, Quaternion.identity);
    }
}
