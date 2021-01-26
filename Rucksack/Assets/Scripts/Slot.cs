using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    //Verankerung der Gegenständer*innen
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

    //Ablegen des Gegenstandes
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            DragHandeler.itemBeingDragged.transform.SetParent(transform);
            controller.GetComponent<GlobalValues>().addItem(DragHandeler.itemBeingDragged.GetComponent<ItemValues>().id, 
                                                            DragHandeler.itemBeingDragged.GetComponent<ItemValues>().value, 
                                                            DragHandeler.itemBeingDragged.GetComponent<ItemValues>().weight,
                                                            DragHandeler.itemBeingDragged.GetComponent<ItemValues>().name);
        }
    }
}
