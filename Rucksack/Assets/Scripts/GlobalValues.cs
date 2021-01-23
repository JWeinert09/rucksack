using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalValues : MonoBehaviour
{
    private bool activePopup = false;
    //In Nest befindliche Items
    int[] values = new int[10];
    int[] weights = new int[10];
    string[] names = new string[10];

    //Gegebene Items
    public int[] givenValues = new int[10];
    public int[] givenWeights = new int[10];
    public string[] givenNames = new string[10];
 
    private int maxWeight  = 50;

    public Text textValues;
    public Text textWeights;

    public GameObject pop_test;
    public GameObject pop_fail;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < values.Length; i++) {
            values[i] = 0;
            weights[i] = 0;
        }

        this.initialising();
        
    }

    // Update is called once per frame
    void Update()
    {
        this.refresh();
    }

    public bool getPop() {
        return activePopup;
    }

    public void addItem(int id, int v, int w, string n) {
        values[id] = v;
        weights[id] = w;
        names[id] = n;
        this.refresh();

        if(this.getGlobalWeight() > maxWeight) {
            Instantiate(pop_fail, new Vector3(573, 219, 5), Quaternion.identity);
            activePopup = true;
        }
    }

    public void removeItem(int id) {
        values[id] = 0;
        weights[id] = 0;
        names[id] = "";
        this.refresh();
    }

    public int getGlobalValue() {
        int gv = 0;
        for(int i = 0; i < values.Length; i++) {
            gv = gv + values[i];
        }
        return gv;
    } 

    public int getGlobalWeight() {
        int gw = 0;
        for(int i = 0; i < weights.Length; i++) {
            gw = gw + weights[i];
        }
        return gw;
    }

    public void initialising() {
        textValues.text = "0";
        textWeights.text = "0";
    }

    public void refresh() {
        int v = this.getGlobalValue();
        int w = this.getGlobalWeight();
        textValues.text = v.ToString();
        textWeights.text = w.ToString();
    }

    public void check() {
        if(!activePopup) {
            Text[] check_text = pop_test.GetComponentsInChildren<Text>();
            System.Random random = new System.Random();
            /* string t = "Das Nest enthält: \n";
            for(int i = 0; i < values.Length; i++) {
                if(values[i] != 0) {
                    t = t + names[i] + ": Wert: " + values[i] + ". Gewicht: " + weights[i] + ".\n";
                }
            } */
            string txt = gameObject.GetComponent<UbungGreedy>().greedy(givenWeights, givenValues, givenNames, names);
            check_text[1].text = txt;
            Instantiate(pop_test, new Vector3(573, 219, 5), Quaternion.identity);
            activePopup = true;
        }
        
    }
}
