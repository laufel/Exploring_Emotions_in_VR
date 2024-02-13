using System.Collections;
using System.Collections.Generic;
using PathCreation;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BatController : MonoBehaviour
{
    private Animator mAnimator;
    public float detectRadius = 3f;
    private GameObject playerXR;
    private XRController XRcontroller;
    public PathCreator pathCreator;
    public float speed = 1.0f;
    float distanceTravelled;
    bool isflying = false;


    // Start is called before the first frame update
    void Start()
    {

        playerXR = GameObject.FindWithTag("Player");
        XRcontroller = playerXR.GetComponentInChildren<XRController>();

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, playerXR.transform.position);
        if (distance <= detectRadius)
        {
            isflying = true;
            
        }
        if (isflying)
        {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }
 
    }
}
