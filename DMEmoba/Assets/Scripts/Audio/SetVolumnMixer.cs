using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolumnMixer : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetMasterLevel(float sliderValue)
    {
        mixer.SetFloat("volumnMaster", Mathf.Log10(sliderValue) * 20);
    }

    public void SetMusicLevel(float sliderValue)
    {
        mixer.SetFloat("bgMusic", Mathf.Log10(sliderValue) * 20);
    }

    public void SetSoundEffectLevel(float sliderValue)
    {
        mixer.SetFloat("soundEffect", Mathf.Log10(sliderValue) * 20);
        FindObjectOfType<AudioManager>().Play("startButton2");
    }
}
