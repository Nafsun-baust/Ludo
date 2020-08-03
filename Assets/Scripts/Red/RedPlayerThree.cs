using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerThree : MonoBehaviour
{
    public static string redPlayerThreeColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            redPlayerThreeColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Red House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        redPlayerThreeColName = "none";
    }
}
