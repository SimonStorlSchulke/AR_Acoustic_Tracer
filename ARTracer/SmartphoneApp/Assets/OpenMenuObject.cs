using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenuObject : MonoBehaviour
{
    public GameObject MenuObject;
    bool open = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.CompareTag("TouchObject"))
                {
                    if (open == false)
                    {
                        // Either touch down or Mouse click
                        Debug.Log("MENUOPEN");
                        MenuObject.SetActive(true);
                    }

                    else if (open == true)
                    {
                        // Either touch down or Mouse click
                        Debug.Log("MENUCLOSE");
                        MenuObject.SetActive(false);
                    }
                }
            }
        }
    
    }
}
