using System.Collections;
using System.Collections.Generic;
using PathCreation;
using UnityEngine;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SnakeAnimation : MonoBehaviour
{
    private Animator mAnimator;
    private float detectRadius = 4.5f;
    private GameObject playerXR;
    private XRController XRcontroller;
    public PathCreator pathCreator;
    public float speed = 1.0f;
    float distanceTravelled;
    bool isJump = false;


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
            isJump = true;

        }
        else { mAnimator.SetBool("PlayerClose", false); }

        if (isJump)
        {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }

    }

}


