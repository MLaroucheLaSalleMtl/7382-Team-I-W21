using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private GameObject[] tutorials;
    private int tutorialIndex;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < tutorials.Length; i++)
        {
            if(i == tutorialIndex)
            {
                tutorials[i].SetActive(true);
            }
            else
            {
                tutorials[i].SetActive(false);
            }
        }

        if(tutorialIndex == 0)
        {
            if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                tutorialIndex++;
            }
        }
        else if(tutorialIndex == 1)
        {
            if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
            tutorialIndex++;
        }
    }
}
