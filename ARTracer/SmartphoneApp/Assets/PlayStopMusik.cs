using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStopMusik : MonoBehaviour
{
    public GameObject AudioSource;
    bool Musikon = false;
    // Start is called before the first frame update
    public void PlayMusik()
    {
        if (!Musikon)
        {
            AudioSource.SetActive(true);
            Musikon = true;
        }

        else if (Musikon)
        {
            AudioSource.SetActive(false);
            Musikon = false;
        }
    }
}
