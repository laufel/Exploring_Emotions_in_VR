using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ScreamSchedule : MonoBehaviour
{
    private AudioSource screamAudio;
    private float detectRadius = 10.0f;
    private GameObject playerXR;
    private XRController XRcontroller;

    // Start is called before the first frame update
    void Start()
    {
        playerXR = GameObject.FindWithTag("Player");
        XRcontroller = playerXR.GetComponentInChildren<XRController>();
        screamAudio = transform.GetComponent<AudioSource>();
        screamAudio.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, playerXR.transform.position);
        if (distance <= detectRadius)
        {
            screamAudio.Play();
        }
    }
}
