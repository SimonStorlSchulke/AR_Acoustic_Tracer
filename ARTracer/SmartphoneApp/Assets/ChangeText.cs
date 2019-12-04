using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public GameObject OpenText;
    public GameObject CloseText;

    public void OnButtonClick()
    {
        if (OpenText.activeSelf == true)
        {
            OpenText.SetActive(false);
            CloseText.SetActive(true);
        }
        else
        {
            OpenText.SetActive(true);
            CloseText.SetActive(false);
        }
    }
}
