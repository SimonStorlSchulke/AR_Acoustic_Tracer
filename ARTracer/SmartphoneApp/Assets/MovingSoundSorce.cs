using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSoundSorce : MonoBehaviour
{
    private bool holding;
    public Material Glow;
    public Material Normal;
    public GameObject SoundSorce;
    public Material SoundSorceMaterial;




    void Start()
    {
        holding = false;
   
        SoundSorceMaterial = SoundSorce.GetComponent<Renderer>().material;
        SoundSorce.GetComponent<Renderer>().material = Normal;
    }

    void Update()
    {

        if (holding)
        {
            SoundSorce.GetComponent<Renderer>().material = Glow;

            Move();
        }



        // One finger
        if (Input.touchCount == 1)
        {

            // Tap on Object
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100f))
                {
                    if (hit.transform == transform)
                    {
                        holding = true;



                    }
                }
            }

            // Release
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                holding = false;
                SoundSorce.GetComponent<Renderer>().material = Normal;

            }


        }
    }

    void Move()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        // The GameObject this script attached should be on layer "Surface"
        if (Physics.Raycast(ray, out hit, 30.0f, LayerMask.GetMask("Swipe")))
        {
            transform.position = new Vector3(hit.point.x,
                                             hit.point.y,
                                             transform.position.z);

        }


    }
}
