using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroythis : MonoBehaviour
{
    public GameObject Soundsorce;
   public void Delete()
    {
        Destroy(Soundsorce);
    }
}
