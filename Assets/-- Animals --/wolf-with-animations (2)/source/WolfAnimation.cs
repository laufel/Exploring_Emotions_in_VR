using System.Collections;
using System.Collections.Generic;
using PathCreation;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class WolfAnimation : MonoBehaviour
{
    private Animator mAnimator;
    public float detectRadius=5f;
    public float detectRadius2=1f;
    private GameObject playerXR;
    private XRController XRcontroller;
    public PathCreator pathCreator;
    public float speed = 3.0f;
    float distanceTravelled;
    bool isRunning=false;
    private AudioSource runAudio;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        playerXR = GameObject.FindWithTag("Player");
        XRcontroller = playerXR.GetComponentInChildren<XRController>();
        runAudio = transform.Find("RunAudioSource").GetComponent<AudioSource>();
        runAudio.Stop();
    }

    // Update is called once per frame
    void Update()
    { 
        float distance = Vector3.Distance(transform.position, playerXR.transform.position);
        if(distance <= detectRadius && distance >= detectRadius2)
        {
            mAnimator.SetBool("PlayerClose", true);
        } else
        {
            mAnimator.SetBool("PlayerClose", false);
        }
        if(distance <= detectRadius2)
        {
            mAnimator.SetBool("PlayerveryClose", true);
            isRunning = true;
            runAudio.Play();
        }
        if (isRunning) {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }

    }
}
