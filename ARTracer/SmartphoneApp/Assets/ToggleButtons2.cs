using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButtons2 : MonoBehaviour
{
    public GameObject[] toggleObjects;
    bool isShow = true;
    public GameObject Slider;
    public GameObject Volumen;

    public void OnButtonClick()
    {
        if (isShow == false)
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
            if (Slider.activeSelf == true)
            {
                Slider.SetActive(false);
                Volumen.GetComponent<Toggle_Buttons>().isShow = false;
            }
        }
    }
}

