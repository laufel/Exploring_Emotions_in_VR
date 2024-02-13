using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playonschedule_idle : MonoBehaviour
{
    private AudioSource idleAudio;
    public float playInterval = 70.0f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        idleAudio = transform.GetComponent<AudioSource>();
        timer = playInterval;


    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0.0f)
        {
            idleAudio.Play();
            timer = playInterval;
        }
        
    }
}
