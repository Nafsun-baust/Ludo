using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerTwo : MonoBehaviour
{
    public static string redPlayerTwoColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            redPlayerTwoColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Red House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        redPlayerTwoColName = "none";
    }

}
