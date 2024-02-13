using System.Collections;
using System.Collections.Generic;
using PathCreation;
using UnityEngine;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class CrowAnimation : MonoBehaviour
{
    private Animator mAnimator;
    private float detectRadius=10.0f;
    private GameObject playerXR;
    private XRController XRcontroller;
    public PathCreator pathCreator;
    public float speed = 1.0f;
    float distanceTravelled;
    bool isFlying = false;
    private AudioSource flyAudio;
    private float timer = 0.0f;
    private float targetTime = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        playerXR = GameObject.FindWithTag("Player");
        XRcontroller = playerXR.GetComponentInChildren<XRController>();
        flyAudio = transform.GetComponent<AudioSource>();
        flyAudio.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, playerXR.transform.position);
        if (distance <= detectRadius)
        {

            timer += Time.deltaTime;
            mAnimator.SetBool("PlayerClose", true);
            flyAudio.Play();
            
            if ( timer >= targetTime)
            {
               mAnimator.SetBool("TimeToFly", true);
               isFlying = true;
                distanceTravelled = 0.0f;

            } else { 
               mAnimator.SetBool("TimeToFly", false); 
            }
        } else { mAnimator.SetBool("PlayerClose", false); }
 
        if (isFlying)
        {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }

    }

}
