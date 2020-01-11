using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjetTouch : MonoBehaviour
{
    private bool holding;
    public Material Glow;
    public Material Normal;
    public GameObject SoundSorce;
   public  Material SoundSorceMaterial;
    public int Drop = 0;
    public GameObject PlaceSoundSorcePrefab;
    public GameObject StandSurcePrefab;
    public Vector3 Position;
    public Vector3 newPosition;
    public GameObject hold, release, place;

    void Start()
    {
        holding = false;
        Position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        SoundSorceMaterial = SoundSorce.GetComponent<Renderer>().material;
        SoundSorce.GetComponent<Renderer>().material = Normal;
        //Instantiate(PlaceSoundSorcePrefab, transform.position, new Quaternion(0, 90, 0, 90));
    }

    void Update()
    {

        if (holding)
        {
            SoundSorce.GetComponent<Renderer>().material = Glow;

            Drop = 1;
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
                    if (hit.collider.CompareTag("PlaceObject"))
                    {
                        if (hit.transform == transform)
                        {
                            holding = true;

                            hold.SetActive(false);
                            release.SetActive(true);
                            place.SetActive(false);

                        }
                    }
                }
            }

            // Release
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                if (holding == true)
                {
                    holding = false;
                    SoundSorce.GetComponent<Renderer>().material = Normal;

                    Instantiate(PlaceSoundSorcePrefab, newPosition, new Quaternion(0, 90, 0, 90));


                    hold.SetActive(false);
                    release.SetActive(false);
                    place.SetActive(true);

                }
                
                if (Drop == 1)
                {
                    transform.position = Position;

                }
            }

            
        }
    }

    void Move()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        // The GameObject this script attached should be on layer "Surface"
        if (Physics.Raycast(ray, out hit, 30.0f, LayerMask.GetMask("Surface")))
        {
            newPosition = new Vector3(hit.point.x,
                                             hit.point.y,
                                             transform.position.z);
            transform.position = newPosition;

        }

       
        
    }
}

