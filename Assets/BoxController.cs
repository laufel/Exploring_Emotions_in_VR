using System.Collections;
using System.Collections.Generic;
using System.Threading;
using PathCreation;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    private Animator mAnimator;


    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void GoAnimation()
    {
        mAnimator.SetBool("Open", true);
    }
}