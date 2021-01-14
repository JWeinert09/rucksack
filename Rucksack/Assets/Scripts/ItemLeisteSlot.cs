using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemLeisteSlot : MonoBehaviour, IDropHandler
{
    public GameObject controller;
    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            DragHandeler.itemBeingDragged.transform.SetParent(transform);
            //Debug.Log(DragHandeler.itemBeingDragged.GetComponent<ItemValues>().name + " hat einen Wert von: " + DragHandeler.itemBeingDragged.GetComponent<ItemValues>().value + " und ein Gewicht von: " + DragHandeler.itemBeingDragged.GetComponent<ItemValues>().weight);
            controller.GetComponent<GlobalValues>().removeItem(DragHandeler.itemBeingDragged.GetComponent<ItemValues>().id);
        }
    }
}
