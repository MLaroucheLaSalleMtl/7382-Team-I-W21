using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Pause : MonoBehaviour
{
    [SerializeField] private GameObject pauseUI;
    private bool isPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }
    public void Pause()
    {
        isPaused = true;
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        isPaused = false;
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
