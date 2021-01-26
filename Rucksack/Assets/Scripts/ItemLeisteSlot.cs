using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemLeisteSlot : MonoBehaviour, IDropHandler
{
    //Verankerung der Gegenstände im Slot
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

    //Hereinlegen der Gegenstände in die Slots
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            DragHandeler.itemBeingDragged.transform.SetParent(transform);
            controller.GetComponent<GlobalValues>().removeItem(DragHandeler.itemBeingDragged.GetComponent<ItemValues>().id);
        }
    }
}
