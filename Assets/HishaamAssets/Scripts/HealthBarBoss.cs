using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarBoss : MonoBehaviour
{

    public Image hpIm;
    public Image hpback;

    private float hp;
    [SerializeField] private float maxHp;
    [SerializeField]

    private void Start()
    {
        hp = maxHp;
    }

    private void Update()
    {
        hpIm.fillAmount = hp / maxHp;

        if(hpback.fillAmount>hpIm.fillAmount)
        {
            //hpback.fillAmount -= hurtSpeed;
        }
    }
}
