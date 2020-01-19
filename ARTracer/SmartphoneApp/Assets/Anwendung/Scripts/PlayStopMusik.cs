using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStopMusik : MonoBehaviour
{
    public GameObject AudioSource;
    public bool Musikon = false;
    int playes = 0;
    // Start is called before the first frame update
    public void PlayMusik()
    {
        if (!Musikon && playes == 0)
        {
            AudioSource.SetActive(true);     
            Musikon = true;
            playes = 1;
        }

        else if (!Musikon && playes == 1)
        {
            Musikon = true;
            AudioSource.GetComponent<AudioSource>().Play();
        }

        else if (Musikon && playes == 1)
        {
            AudioSource.GetComponent<AudioSource>().Pause();
            Musikon = false;
        }
    }
}
