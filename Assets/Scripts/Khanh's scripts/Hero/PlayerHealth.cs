using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int heroHealth;
    [SerializeField] private int numOfHealth;

    [SerializeField] private Image[] healthIcon;
    [SerializeField] private Sprite fullHeart;
    [SerializeField] private Sprite emptyHeart;
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
        {
            if(i < heroHealth) //Number of hearts is smaller than hero health   
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
        heroHealth--;
    }
}
