using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentTime : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondsHand;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int hour = DateTime.Now.Hour;
        int minute = DateTime.Now.Minute;
        int second = DateTime.Now.Second;

        float hourAngle = hour * 30f + minute * 0.5f;
        float minuteAngle = minute * 6f + second*0.1f;
        float secondAngle = second * 6f;
        
        hourHand.localEulerAngles = new Vector3(hourAngle,0f,0f);
        minuteHand.localEulerAngles = new Vector3(minuteAngle, 0f, 0f);
        secondsHand.localEulerAngles = new Vector3(secondAngle, 0f, 0f);

    }
}
