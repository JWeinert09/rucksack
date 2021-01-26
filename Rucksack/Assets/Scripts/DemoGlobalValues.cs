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
 
    private int maxWeight  = 50;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<DemoGreedy>().demo(givenWeights, givenValues, givenNames, objects);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int getGlobalValue() {
        int gv = 0;
        for(int i = 0; i < givenValues.Length; i++) {
            gv = gv + givenValues[i];
        }
        return gv;
    } 

    public int getGlobalWeight() {
        int gw = 0;
        for(int i = 0; i < givenWeights.Length; i++) {
            gw = gw + givenWeights[i];
        }
        return gw;
    }
}