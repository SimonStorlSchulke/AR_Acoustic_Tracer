using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Vuforia;

public class ItemDropHandler : MonoBehaviour, IDropHandler
{
    public GameObject myPrefab;
    Touch touchs;
    Vector3 touchposition;
    public GameObject MidAir;
    public GameObject PlaceSoundSorce;
    ContentPositioningBehaviour MidAirScript;

    void Start()
    {
      
        

    }

    void Update()

    {
        MidAir = GameObject.FindGameObjectWithTag("MidAir");
        MidAirScript = MidAir.gameObject.GetComponent<ContentPositioningBehaviour>();
        MidAirScript.AnchorStage = GameObject.FindGameObjectWithTag("Stage").GetComponent<AnchorBehaviour>();
        touchs = Input.GetTouch(0);
        touchposition = this.transform.position;
        Debug.Log(touchposition);

    }



    public void OnDrop(PointerEventData eventData)
    {
        RectTransform invPanel = transform as RectTransform;

        if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel, touchs.position))
        {
            Debug.Log("Drop item");
           // this.gameObject.SetActive(false);
            Instantiate(myPrefab, touchposition, new Quaternion(0,90,0,90));
            PlaceSoundSorce.SetActive(false);
           
        }
    }
}

