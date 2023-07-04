using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;


    void Awake()
    {
        if(instance == null)
        {
            instance = this; // Set the instance to this AudioManager
        }
        else
        {
            Destroy(gameObject); // Destroy the AudioManager game object
            return; // Exit the function
        }

        DontDestroyOnLoad(gameObject); // Don't destroy the AudioManager game object when loading a new scene

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>(); // Add an AudioSource component to the AudioManager game object
            s.source.clip = s.clip; // Set the clip of the AudioSource to the clip in the Sound class

            s.source.volume = s.volume; // Set the volume of the AudioSource to the volume in the Sound class
            s.source.pitch = s.pitch; // Set the pitch of the AudioSource to the pitch in the Sound class
            s.source.loop = s.loop; // Set the loop of the AudioSource to the loop in the Sound class
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) // If the sound is not found
        {
            Debug.LogWarning("Sound: " + name + " not found!"); // Log a warning to the console
            return; // Exit the function
        }
        s.source.Play();
    }

}
