using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalValues : MonoBehaviour
{
    int[] values = new int[10];
    int[] weights = new int[10];
    string[] names = new string[10];

    public int globalValue = 0;
    public int globalWeight = 0;
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

    public void addItem(int id, int v, int w, string n) {
        values[id] = v;
        weights[id] = w;
        names[id] = n;
        this.refresh();

        if(globalWeight > maxWeight) {
            Instantiate(pop_fail, new Vector3(573, 219, 5), Quaternion.identity);
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
        textValues.text = "Gesamtwert = 0";
        textWeights.text = "Gesamtgewicht = 0";
    }

    public void refresh() {
        textValues.text = "Gesamtwert = " + this.getGlobalValue();
        textWeights.text = "Gesamtgewicht = " + this.getGlobalWeight();
    }

    public void check() {
        Text[] check_text = pop_test.GetComponentsInChildren<Text>();
        System.Random random = new System.Random();
        string t = "Das Nest enthält: \n";
        for(int i = 0; i < values.Length; i++) {
            if(values[i] != 0) {
                t = t + names[i] + ": Wert: " + values[i] + ". Gewicht: " + weights[i] + ".\n";
            }
        }
        check_text[1].text = t;
        Instantiate(pop_test, new Vector3(573, 219, 5), Quaternion.identity);
    }
}
