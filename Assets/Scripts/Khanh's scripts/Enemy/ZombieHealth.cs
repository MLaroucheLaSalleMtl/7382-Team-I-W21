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
        zombieHealth--;
        Instantiate(damagePoint, damageDisplayPos.transform.position, Quaternion.identity);
    }
}
