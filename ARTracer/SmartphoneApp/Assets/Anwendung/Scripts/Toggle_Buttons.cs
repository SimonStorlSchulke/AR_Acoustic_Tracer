using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_Buttons : MonoBehaviour
{
    public GameObject[] toggleObjects;
    public bool isShow = false;
    
    public void OnButtonClick()
    {

        if(isShow == false)
        {
            for (int i = 0; i < toggleObjects.Length; i++)
            {
                toggleObjects[i].SetActive(true);
            }
            isShow = true;
        }

        else if (isShow == true)
        {
            for (int i = 0; i < toggleObjects.Length; i++)
            {
                toggleObjects[i].SetActive(false);
            }

            isShow = false;
        }
    }

    public void Show()
    {
        isShow = false;
    }
}
