using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerStrikeHurt : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D PSCol)
    {
        if (PSCol.CompareTag("Enemy"))
        {
            PSCol.GetComponent<ZombieHealth>().PowerStrikeHurt();
            Debug.Log("Power Strike-ed");
        }

        if (PSCol.CompareTag("Minotaur"))
        {
            PSCol.GetComponent<MinotaurHealth>().Hurt();
        }

        if (PSCol.CompareTag("Crab"))
        {
            PSCol.GetComponent<HealthBarBoss>().hp -= 15;
            PSCol.GetComponent<HealthBarBoss>().Die();
        }
    }
}
