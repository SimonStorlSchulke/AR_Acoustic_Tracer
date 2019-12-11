using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BoolDuplicate : MonoBehaviour
{
    ContentPositioningBehaviour scripty;
    // Start is called before the first frame update
    void Start()
    {
        scripty = gameObject.GetComponent<ContentPositioningBehaviour>();
    }

    // Update is called once per frame
   public void OnTouch(bool state)
    {
        scripty.DuplicateStage = state;
    }
}
