﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class PlaceObject : MonoBehaviour
{
    public GameObject ObjectToPlace;
    private MLInputController controller;


    // Start is called before the first frame update
    void Start()
    {
        MLInput.Start();
        MLInput.OnControllerButtonDown += OnButtonDown;
        controller = MLInput.GetController(MLInput.Hand.Left);


    }

    void OnButtonDown(byte controller_id, MLInputControllerButton button)
    {
        if (button == MLInputControllerButton.Bumper)
        {
            RaycastHit hit;
            if(Physics.Raycast(controller.Position, transform.forward, out hit))
            {
                GameObject placeObject = Instantiate(ObjectToPlace, hit.point, Quaternion.Euler(hit.normal));
            }
        }
    }

    private void OnDestroy()
    {
        MLInput.Start();
        MLInput.OnControllerButtonDown -= OnButtonDown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
