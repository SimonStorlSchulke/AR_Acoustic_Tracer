using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMusik : MonoBehaviour
{
    public AudioSource Audio;
    public NextMusik NextMusik;
    public GameObject NextButton;

    // Start is called before the first frame update

    public void Start()
    {
       NextMusik = NextButton.GetComponent<NextMusik>();
    }

    public void Back()
    {

        
        if(NextMusik.click <= 1)
        {
            NextMusik.i = NextMusik.showObjects.Count -1;
            NextMusik.click = NextMusik.showObjects.Count;

        }
        else if (NextMusik.click <= NextMusik.showObjects.Count)
        {
            --NextMusik.i;
            --NextMusik.click;

        }


        Audio.clip = NextMusik.showObjects[NextMusik.i];
        Audio.Play();
    }
}
