using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioClip buttonAudioClip;
    public AudioClip dismissalAudioClip;
    public AudioClip diceAudioClip;
    public AudioClip winAudioClip;
    public AudioClip safeHouseAudioClip;
    public AudioClip playerAudioClip;
    //public AudioClip BGAudioClip;
    //public AudioClip BGGBAudioClip;

    public static AudioSource buttonAudioSource;
    public static AudioSource dismissalAudioSource;
    public static AudioSource diceAudioSource;
    public static AudioSource winAudioSource;
    public static AudioSource safeHouseAudioSource;
    public static AudioSource playerAudioSource;
    //public static AudioSource BGAudioSource;
    //public static AudioSource BGGPAudioSource;
    public AudioSource AddAudio(AudioClip clip , bool playOnAwake,bool loop,float volume)
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.playOnAwake = playOnAwake;
        audioSource.loop = loop;
        audioSource.volume = volume;
        return audioSource;

    }
    // Start is called before the first frame update
    void Start()
    {
        buttonAudioSource = AddAudio(buttonAudioClip, false, false, 1.0f);
        dismissalAudioSource = AddAudio(dismissalAudioClip, false, false, 1.0f);
        diceAudioSource = AddAudio(diceAudioClip, false, false, 1.0f);
        winAudioSource = AddAudio(winAudioClip, false, false, 1.0f);
        safeHouseAudioSource = AddAudio(safeHouseAudioClip, false, false, 1.0f);
        playerAudioSource = AddAudio(playerAudioClip, false, false, 1.0f);
        //BGAudioSource = AddAudio(BGAudioClip, true, true, 1.0f);
        //BGAudioSource = AddAudio(BGAudioClip, true, true, 1.0f);
    }
  
    
}
