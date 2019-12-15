using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChanger : MonoBehaviour
{

    public List<GameObject> Buttons = new List<GameObject>();
    public List<GameObject> ButtonsOff = new List<GameObject>();
    public GameObject On;
    public GameObject Button2, Button3, Button4;


    void Awake()
    {
        foreach (GameObject button in GameObject.FindGameObjectsWithTag("Button"))
        {

            Buttons.Add(button);
        }

        foreach (GameObject buttonOff in GameObject.FindGameObjectsWithTag("Off"))
        {

            ButtonsOff.Add(buttonOff);
        }

    }
    
    public void ClickThisButton()
    {

       

            Button2.SetActive(false);
            Button3.SetActive(false);
            Button4.SetActive(false);


            foreach (GameObject buttonoff in ButtonsOff)
            {
                buttonoff.SetActive(true);
            }

        
        
    }
}
