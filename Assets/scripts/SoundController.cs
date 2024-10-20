using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Reference to the Audio Source
    public AudioSource audioSource;

    // To track whether the sound is playing or paused
    private bool isPlaying = true;

    // Start is called before the first frame update
    void Start()
    {
        // Play the sound when the scene starts
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the 'M' key is pressed
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isPlaying)
            {
                // Pause the sound if it's currently playing
                audioSource.Pause();
                isPlaying = false;
            }
            else
            {
                // Resume playing the sound if it's paused
                audioSource.UnPause();
                isPlaying = true;
            }
        }
    }
}