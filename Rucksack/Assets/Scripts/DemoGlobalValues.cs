using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoGlobalValues : MonoBehaviour
{
     //Gegebene Items
    public int[] givenValues = new int[10];
    public int[] givenWeights = new int[10];
    public string[] givenNames = new string[10];
    public GameObject[] objects = new GameObject[10];
    //Maximalgewicht
    private int maxWeight  = 50;

    // Start is called before the first frame update
    void Start()
    {   //Start des Algorithmuses in der Demo
        gameObject.GetComponent<DemoGreedy>().demo(givenWeights, givenValues, givenNames, objects);
    }
}