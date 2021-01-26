using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;
    Text item_Text;

    //Initalisierung Textanzeige
    void Start() {
        item_Text = GameObject.Find("Text_Item").GetComponent<Text>();
    }

    //Aufnahme des Gegenstandes
    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        item_Text.text = "Aktuelles Item: " + itemBeingDragged.GetComponent<ItemValues>().name + "\nGewicht: " + itemBeingDragged.GetComponent<ItemValues>().weight + ". Wert: " + itemBeingDragged.GetComponent<ItemValues>().value;
    }

    //Umherziehen des Gegenstandes
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    //Ablegen des Gegenstandes
    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
        
    }
}
