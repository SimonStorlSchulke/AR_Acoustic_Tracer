using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowVolumen : MonoBehaviour
{
   
    private int showObjectsCount = 9;
    public List<GameObject> showObjects = new List<GameObject>();
    bool PlayOn = false;

    // Start is called before the first frame update
    void Awake()
    {
        foreach (GameObject show in GameObject.FindGameObjectsWithTag("ShowObjects"))
        {

            showObjects.Add(show);
        }

    }

    // Update is called once per frame
    public void ShowTheStuff()
    {
        if (!PlayOn)
        {
            PlayOn = true;
            foreach (GameObject show in showObjects)
            {
                for (int a = 0; a < transform.childCount; a++)
                {
                    show.transform.GetChild(a).gameObject.SetActive(true);
                }
            }
           
        }

        else if (PlayOn)
        {
            PlayOn = false;
            foreach (GameObject show in showObjects)
            {
                for (int a = 0; a < transform.childCount; a++)
                {
                    show.transform.GetChild(a).gameObject.SetActive(false);
                }
            }
            
        }
    }
}

 
 
         