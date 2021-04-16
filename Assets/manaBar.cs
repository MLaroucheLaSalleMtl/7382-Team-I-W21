using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manaBar : MonoBehaviour
{
    public Image maNaIm;
    public Image manaBackground;

    public float mana;
    private float maxMana=100f;
    private float reduceSpeed = 0.005f;

    

    // Start is called before the first frame update
    void Start()
    {
        mana = maxMana;
    }

    // Update is called once per frame
    void Update()
    {
        maNaIm.fillAmount = mana / maxMana;
        if (manaBackground.fillAmount > maNaIm.fillAmount)
        {
            manaBackground.fillAmount -= reduceSpeed;
        }
        else
        {
            manaBackground.fillAmount = maNaIm.fillAmount;
        }
    }
}
