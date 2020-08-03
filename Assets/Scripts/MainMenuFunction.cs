using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenuFunction : MonoBehaviour
{
    public GameObject VolumeOn;
    public GameObject VolumeOff;
    public AudioSource Audio;
    void Start()
    {
        PlayerPrefs.SetInt("BGVolume", 1);
    }
    public void PlayMenu()
    {
        SoundManager.buttonAudioSource.Play();
        SceneManager.LoadScene("MainMenu");
    }
    public void SettingMenu()
    {
        SoundManager.buttonAudioSource.Play();
        
    }
    public void QuitMenu()
    {
        SoundManager.buttonAudioSource.Play();
        Application.Quit();
    }
  
    public void VolumeOnClick() //it will toggle to volume off
    {
        VolumeOff.SetActive(true);
        VolumeOn.SetActive(false);
        PlayerPrefs.SetInt("BGVolume", 1);
        Audio.volume = 1f;
        //SoundManager.BGAudioSource.Play();
    }
    public void VolumeOffClick()//it will toggle to volume on
    {
        VolumeOn.SetActive(true);
        VolumeOff.SetActive(false);
        PlayerPrefs.SetInt("BGVolume", 0);
        Audio.volume = 0f;
        //SoundManager.BGAudioSource.Stop();

    }
}
