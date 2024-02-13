using System.Collections;
using System.Collections.Generic;
using System.Threading;
using PathCreation;
using UnityEngine;
public class FireworksAnimator : MonoBehaviour
{
    private Animator mAnimator;
    private float timer = 0.0f;
    private AudioSource fireworks;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        fireworks = transform.Find("ClapAudioSource").GetComponentInChildren<AudioSource>();
        

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer >= 160.0f && timer < 320.0f)
        {
            mAnimator.SetBool("Timer1", true);
            fireworks.Play();
        }

        else if (timer >= 320.0f)
        {
            mAnimator.SetBool("Timer1", false);
            fireworks.Stop();
        }
    }
}
