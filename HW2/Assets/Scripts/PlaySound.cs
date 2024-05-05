using UnityEngine;

public class PlaySound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Check for input to toggle the voice on/off
        if (Input.GetKeyDown(KeyCode.V))
        {
            // Toggle the mute state of the AudioSource
            audioSource.mute = !audioSource.mute;

            // Optionally, you can add visual or audio feedback here
            if (audioSource.mute)
            {
                Debug.Log("Voice muted");
            }
            else
            {
                Debug.Log("Voice unmuted");
            }
        }
    }
}
