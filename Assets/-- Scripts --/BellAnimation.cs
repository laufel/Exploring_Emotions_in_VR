using System.Collections;
using System.Collections.Generic;
using System.Threading;
using PathCreation;
using UnityEngine;

public class BellAnimation : MonoBehaviour
{
    private Animator mAnimator;
    private float timer = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator.GetBool("Grab")) {
            timer += Time.deltaTime;
        }
        if (timer >= 1.0f) {
            mAnimator.SetBool("Grab", false);
            timer = 0.0f;
        }
    }


    public void StartAnimation()
    {
        mAnimator.SetBool("Grab", true);
    }

}
