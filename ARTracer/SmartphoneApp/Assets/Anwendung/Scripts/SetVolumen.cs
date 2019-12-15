using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVolumen : MonoBehaviour
{
    public AudioSource Audio;
    Slider sliderv;
    public Image VolumenImage;

     void Start()
    {
        sliderv = gameObject.GetComponent<Slider>();
    }

    public void SetVolum()
    {
        Audio.volume = sliderv.value;
        VolumenImage.fillAmount = sliderv.value;
    }

}
