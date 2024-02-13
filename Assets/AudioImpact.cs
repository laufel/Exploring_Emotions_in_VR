using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioImpact : MonoBehaviour
{
    public AudioClip collisionSound;
    private AudioSource audioSource;
    private bool stateCollision = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = collisionSound;
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Surface") && !stateCollision)
        {
            stateCollision = true;
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Surface") && stateCollision)
        {
            audioSource.Play();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
