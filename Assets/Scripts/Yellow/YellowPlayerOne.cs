using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlayerOne : MonoBehaviour
{
    public static string yellowPlayerOneColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            yellowPlayerOneColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Yellow House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        yellowPlayerOneColName = "none";
    }
}
