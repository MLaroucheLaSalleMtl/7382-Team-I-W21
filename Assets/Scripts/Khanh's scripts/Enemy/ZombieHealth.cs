using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    [SerializeField] private int zombieHealth;
    [SerializeField] private GameObject damagePoint, damageDisplayPos;

    private PlayerHealth heroHealthGain;

    private int zombieHealthLoss = 1;
    // Start is called before the first frame update
    void Start()
    {
        heroHealthGain = GetComponent<PlayerHealth>();
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
        zombieHealth -= zombieHealthLoss;
        Instantiate(damagePoint, damageDisplayPos.transform.position, Quaternion.identity);
    }

    public void PowerStrikeHurt()
    {
        zombieHealth -= zombieHealthLoss * 2;
        Instantiate(damagePoint, damageDisplayPos.transform.position, Quaternion.identity);
    }
    public void BFHurt()
    {
        zombieHealth -= zombieHealthLoss;
        Instantiate(damagePoint, damageDisplayPos.transform.position, Quaternion.identity);
    }
}
