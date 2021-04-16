using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurHealth : MonoBehaviour
{
    [SerializeField] private int minotaurHealth;

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (minotaurHealth <= 0)
        {
            anim.SetTrigger("Death");
            
            //gameObject.SetActive(false);
        }
            
    }

    public void Hurt()
    {
        minotaurHealth--;
    }
}
