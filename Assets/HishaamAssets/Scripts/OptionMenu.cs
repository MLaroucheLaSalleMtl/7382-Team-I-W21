using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Adding background OST (Controlling volume)
    public void SFX(float sfx)
    {
        audioMixer.SetFloat("MySFX", sfx);
    }

    //setting the graphics(low, medium, high)
    public void Graphics(int grapConfig)
    {
        QualitySettings.SetQualityLevel(grapConfig);
    }
}
