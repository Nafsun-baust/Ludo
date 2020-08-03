using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayerOne : MonoBehaviour
{
    public static string greenPlayerOneColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            greenPlayerOneColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Green House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        greenPlayerOneColName = "none";
    }
}
