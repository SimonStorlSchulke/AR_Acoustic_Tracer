using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextMusik : MonoBehaviour
{
    public AudioSource Audio;
    public List<AudioClip> showObjects = new List<AudioClip>();
    public int i = 0;
    public int click = 1;

    // Start is called before the first frame update
   
    

    public void Next()
    {
        
        if (click < showObjects.Count)
        {
            ++i;
            ++click;
        }
        else if (click >= showObjects.Count)
        {
            i = 0;
            click = 1;
        }

        Audio.clip = showObjects[i];
        Audio.Play();
    }

}
