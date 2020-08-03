using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayerFour : MonoBehaviour
{
    public static string greenPlayerFourColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            greenPlayerFourColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Green House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        greenPlayerFourColName = "none";
    }
}
