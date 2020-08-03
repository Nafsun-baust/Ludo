using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenuManager : MonoBehaviour
{
    public static int howManyPlayer;
    public AudioSource audio;
    public void Start()
    {
        if (PlayerPrefs.GetInt("BGVolume") == 1)
        {
            audio.volume = 1f;
        }
        else if (PlayerPrefs.GetInt("BGVolume") == 0)
        {
            audio.volume = 0f;
        }
        //SoundManager.BGAudioSource.Play();
    }
    
    public void TwoPlayers()
    {
        SoundManager.buttonAudioSource.Play();
        howManyPlayer = 2;
        SceneManager.LoadScene("Ludo");
    }
    public void ThreePlayers()
    {
        SoundManager.buttonAudioSource.Play();
        howManyPlayer = 3;
        SceneManager.LoadScene("Ludo");
    }
    public void FourPlayers()
    {
        SoundManager.buttonAudioSource.Play();
        howManyPlayer = 4;
        SceneManager.LoadScene("Ludo");
    }
    public void Quit()
    {
        SoundManager.buttonAudioSource.Play();
        Application.Quit();
      
    }
    public void backtomain()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
