using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    [SerializeField] private int zombieHealth;
    [SerializeField] private GameObject damagePoint, damageDisplayPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(zombieHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void Hurt()
    {
        int zombieHurt = 1;
        zombieHealth-=zombieHurt;
        Instantiate(damagePoint, damageDisplayPos.transform.position, Quaternion.identity);
    }

    public void PowerStrikeHurt()
    {
        int zombieHurt = 2;
        zombieHealth -= zombieHurt;
        Instantiate(damagePoint, damageDisplayPos.transform.position, Quaternion.identity);
    }

    public void LifeStolen()
    {
        int zombieHurt = 1;
        zombieHealth -= zombieHurt;
        GetComponent<PlayerHealth>().LifeStealing();
        Instantiate(damagePoint, damageDisplayPos.transform.position, Quaternion.identity);
    }
}
