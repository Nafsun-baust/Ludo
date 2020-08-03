using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerFour : MonoBehaviour
{
    public static string bluePlayerFourColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            bluePlayerFourColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Blues House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        bluePlayerFourColName = "none";
    }
}
