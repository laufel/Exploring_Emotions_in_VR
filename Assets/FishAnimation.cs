using System.Collections;
using System.Collections.Generic;
using PathCreation;
using UnityEngine;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class FishAnimation : MonoBehaviour
{
    private Animator mAnimator;
    private float detectRadius = 2.3f;
    private GameObject playerXR;
    private XRController XRcontroller;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        playerXR = GameObject.FindWithTag("Player");
        XRcontroller = playerXR.GetComponentInChildren<XRController>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, playerXR.transform.position);
        if (distance <= detectRadius)
        {

            mAnimator.SetBool("PlayerClose", true);

        }
        else { mAnimator.SetBool("PlayerClose", false); }
    }
}
