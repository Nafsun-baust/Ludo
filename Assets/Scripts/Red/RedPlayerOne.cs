using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerOne : MonoBehaviour
{

    public static string redPlayerOneColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Blocks")
        {
            redPlayerOneColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Red House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        redPlayerOneColName = "none";
    }

   
}
