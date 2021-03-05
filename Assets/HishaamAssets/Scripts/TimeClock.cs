using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class TimeClock : MonoBehaviour
{

    public float time;
    public Text textTimer;
    public int speed;
    public int days;
    public TimeSpan currentTime;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DayTime();
    }

    public void DayTime()
    {
        time += Time.deltaTime * speed;
        if(time>864000)
        {
            days += 1;
            time = 0;
        }

        currentTime = TimeSpan.FromSeconds(time);

        string[] temptime = currentTime.ToString().Split(":"[0]);
        textTimer.text = temptime[0] + ":" + temptime[1];

    }

}
