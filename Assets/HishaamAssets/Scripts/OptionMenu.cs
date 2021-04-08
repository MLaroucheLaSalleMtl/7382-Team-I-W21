using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{

    public AudioSource audiosource;
    public Slider slider;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Adding background OST (Controlling volume)
    public void SFX()
    {
        audiosource.volume = slider.value;
    }

    //setting the graphics(low, medium, high)
    public void Graphics(int grapConfig)
    {
        QualitySettings.SetQualityLevel(grapConfig);
    }
}
