using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurHealth : MonoBehaviour
{
    [SerializeField] private int minotaurHealth;
    [SerializeField] private GameObject damagePoint, damageDisplayPos;
    [SerializeField] private UI_Victory victoryUI;

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
            victoryUI.DisplayUI();
            anim.SetTrigger("Death");
            
            //gameObject.SetActive(false);
        }
            
    }

    public void Hurt()
    {
        minotaurHealth--;
        Instantiate(damagePoint, damageDisplayPos.transform.position, Quaternion.identity);
    }
}
