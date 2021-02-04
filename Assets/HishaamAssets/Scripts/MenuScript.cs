using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Clicking Play, goes to the next Scene
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    //Clicking Quit, exit game 
    public void Quit()
    {
        Application.Quit();
    }


}
