using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip[] musicTrack;
    private int currentTrackIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.clip = musicTrack[currentTrackIndex];
        audiosource.Play();
        currentTrackIndex++;
    }

    public void PlayNextTrack()
    {
        if (currentTrackIndex == 3)
        {
            audiosource.Stop();
            currentTrackIndex = 0;
        }
        else
        {
            audiosource.clip = musicTrack[currentTrackIndex];
            audiosource.Play();
            currentTrackIndex = currentTrackIndex + 1;

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
