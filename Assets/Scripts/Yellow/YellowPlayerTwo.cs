using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlayerTwo : MonoBehaviour
{
    public static string yellowPlayerTwoColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            yellowPlayerTwoColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Yellow House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        yellowPlayerTwoColName = "none";
    }
}
