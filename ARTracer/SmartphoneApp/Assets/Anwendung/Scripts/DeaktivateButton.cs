using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeaktivateButton : MonoBehaviour
{
    public GameObject PlaceSoundSorceObject;
    public GameObject Object2;
    public GameObject SoundSorce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if(PlaceSoundSorceObject.activeSelf == false)
        {
            SoundSorce.SetActive(false);
        }
    }

    public void Deaktivate()
    {
        PlaceSoundSorceObject.SetActive(false);
        Object2.SetActive(true);
    }
}
