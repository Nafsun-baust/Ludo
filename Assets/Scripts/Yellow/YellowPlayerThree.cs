using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlayerThree : MonoBehaviour
{
    public static string yellowPlayerThreeColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            yellowPlayerThreeColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Yellow House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        yellowPlayerThreeColName = "none";
    }
}
