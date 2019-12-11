using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropHandler : MonoBehaviour, IDropHandler
{

    Touch touchs;

    void Update()
    {
        touchs = Input.GetTouch(0);

    }
    public void OnDrop(PointerEventData eventData)
    {
        RectTransform invPanel = transform as RectTransform;

        if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel, touchs.position))
        {
            Debug.Log("Drop item");
            this.gameObject.SetActive(false);
        }
    }
}

