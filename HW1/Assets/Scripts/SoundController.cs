using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPaused = false;

    void Start()
    {
        // Get the AudioSource component attached to the GameObject
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Check if the 'm' key is pressed
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Toggle between pause and resume
            if (isPaused)
            {
                audioSource.UnPause(); // Resume the audio clip
            }
            else
            {
                audioSource.Pause(); // Pause the audio clip
            }
            isPaused = !isPaused; // Toggle the pause state
        }
    }
}
