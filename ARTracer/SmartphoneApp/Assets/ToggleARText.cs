using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleARText : MonoBehaviour
{
    public GameObject ARTracer;
    public GameObject Other;
    public bool on = false;

    public void OnButtonClick()
    {
        if (on == true && Other.activeSelf == true)
        {
            Debug.Log("OOOON");
            ARTracer.SetActive(true);
            Other.SetActive(false);
            
        }
        
    }
}
