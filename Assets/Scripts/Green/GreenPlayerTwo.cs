using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayerTwo : MonoBehaviour
{
    public static string greenPlayerTwoColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            greenPlayerTwoColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Green House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        greenPlayerTwoColName = "none";
    }
}
