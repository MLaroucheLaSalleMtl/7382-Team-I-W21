using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Victory : MonoBehaviour
{
   public void DisplayUI()
    {
        gameObject.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Demo");
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
