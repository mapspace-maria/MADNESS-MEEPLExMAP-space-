using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // The audio source that will play the music
    public AudioSource audioSource;

    // The audio clip to play
    public AudioClip music;

    void Start()
    {
        // Set the audio clip
        audioSource.clip = music;

        // Play the music
        audioSource.Play();

        // Set the audio to loop
        audioSource.loop = true;
    }
}
