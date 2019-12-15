using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public GameObject OpenText;
    public GameObject CloseText;

    public void OnButtonClick()
    {
        if (CloseText.activeSelf == false)
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
