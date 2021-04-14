using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int heroHealth;//Hero's current health
    [SerializeField] private int numOfHealth;//Number of health icon == max hero's health

    [SerializeField] private Image[] healthIcon;//HHHHH
    [SerializeField] private Sprite fullHeart;//HP existed
    [SerializeField] private Sprite emptyHeart;//HP lost
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(heroHealth > numOfHealth) //Check bug if playerHealth is greater than number of health icons
        {
            heroHealth = numOfHealth;
        }

        for (int i = 0; i < healthIcon.Length; i++)
        {//i = the loss health
            if(i < heroHealth) //the number of health is maller than hero health
            {
                healthIcon[i].sprite = fullHeart;
            }
            else // Hero loses health
            {
                healthIcon[i].sprite = emptyHeart;
            }
        }

        if (heroHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void Hurt()
    {
        int heroHurt;
        heroHurt = 1;
        heroHealth -= heroHurt;
    }

    public void InBravery()
    {
        int heroHurt;
        heroHurt = 0;
        heroHealth -= heroHurt;
    }

    public void LifeStealing()
    {
        int heroHurt;
        heroHurt = -1;
        heroHealth -= heroHurt;
        if (heroHealth < numOfHealth)
        {
            heroHealth++;
            for (int i = 0; i < healthIcon.Length; i++)
            {
                if (i < heroHealth)
                {
                    healthIcon[i].sprite = fullHeart;
                }             
            }
        }
    }
}
