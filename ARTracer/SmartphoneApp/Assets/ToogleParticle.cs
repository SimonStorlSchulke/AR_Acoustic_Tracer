﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToogleParticle : MonoBehaviour
{
   
    public GameObject Rotaion;
    public GameObject PlayButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleParticle()
    {
        if (PlayButton.activeSelf == false)
        {
            
            Rotaion.GetComponent<AutoRotation>().enabled = true;
        }
        else
        {
            
            Rotaion.GetComponent<AutoRotation>().enabled = false;
        }
    }
}
