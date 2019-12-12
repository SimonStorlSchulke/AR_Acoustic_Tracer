using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropHandler : MonoBehaviour, IDropHandler
{
    public GameObject myPrefab;
    Touch touchs;
    Vector3 touchposition;

    void Update()
    {
        touchs = Input.GetTouch(0);
        touchposition = transform.position;
        Debug.Log(touchposition);

    }



    public void OnDrop(PointerEventData eventData)
    {
        RectTransform invPanel = transform as RectTransform;

        if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel, touchs.position))
        {
            Debug.Log("Drop item");
           // this.gameObject.SetActive(false);
            Instantiate(myPrefab, touchposition, Quaternion.identity);
        }
    }
}

