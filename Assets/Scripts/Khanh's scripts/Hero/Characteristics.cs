using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characteristics : MonoBehaviour
{
    [SerializeField] private int physicDamage;
    [SerializeField] private int magicDamage;

    private int getPhysicDamage()
    {
        return this.physicDamage;
    }

    private int getMagicDamage()
    {
        return this.magicDamage;
    }
}
