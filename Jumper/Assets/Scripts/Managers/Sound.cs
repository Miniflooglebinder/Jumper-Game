using UnityEngine.Audio;
using UnityEngine;

[System.Serializable] // This attribute allows us to see the class in the inspector
public class Sound {

    public string name;

    public AudioClip clip;

    [Range(0f, 1f)] // This attribute allows us to use a slider in the inspector
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;

}
