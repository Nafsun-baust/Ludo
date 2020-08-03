using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayerThree : MonoBehaviour
{
    public static string greenPlayerThreeColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            greenPlayerThreeColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Green House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        greenPlayerThreeColName = "none";
    }
}
