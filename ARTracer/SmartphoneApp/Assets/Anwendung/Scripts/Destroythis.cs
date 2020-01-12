using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroythis : MonoBehaviour
{
    public GameObject Soundsorce;
    public int remove = 0;
   public void Delete()
    {
        Soundsorce.SetActive(false);
        GameObject Clone = GameObject.FindGameObjectWithTag("Clone");
        Clone.SetActive(false);

    }
}
