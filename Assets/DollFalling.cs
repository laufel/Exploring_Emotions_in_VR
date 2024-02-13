using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DollFalling : MonoBehaviour
{
    private Animator mAnimator;
    private float detectRadius = 8.0f;
    private GameObject playerXR;
    private XRController XRcontroller;
    

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        playerXR = GameObject.FindWithTag("Player");
        XRcontroller = playerXR.GetComponentInChildren<XRController>();
    }


    void Update()
    {
        float distance = Vector3.Distance(transform.position, playerXR.transform.position);
        if (distance <= detectRadius)
        {
            mAnimator.SetBool("PlayerClose", true);
        }
    }
}
