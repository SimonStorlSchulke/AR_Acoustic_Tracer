using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    Touch touchs;

    void Update()
    {
        touchs = Input.GetTouch(0);

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = touchs.position;
        transform.position = Input.mousePosition;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
    }
}
