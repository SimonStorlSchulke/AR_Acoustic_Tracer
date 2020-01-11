using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    bool open = true;
    public GameObject Animator;

   public void OnClickAni()
    {
        if(open == true)
        {
            Animator.GetComponent<Animator>().Play("Menu_Close");
            open = false;
        }

        else
        {
            Animator.GetComponent<Animator>().Play("Menu_Open");
            open = true;
        }
    }
}
