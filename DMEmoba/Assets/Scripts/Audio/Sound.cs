using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    public AudioMixerGroup audioMixer;

    [Range(0f, 1f)]
    public float volumn = 1;
    [Range(.1f, 3f)]
    public float pitch = 1;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
